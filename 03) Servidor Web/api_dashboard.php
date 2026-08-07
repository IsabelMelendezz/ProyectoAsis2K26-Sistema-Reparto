<?php
// api_dashboard.php
// Alimenta las 4 tarjetas de estadísticas del dashboard (Paquetes, Rutas, Bodegas, Repartidores)
// Basado en el esquema real de Sistema_Reparto.sql

header('Content-Type: application/json');
header('Access-Control-Allow-Origin: *');

$host   = '20.10.10.26';
$db     = 'sistema_reparto';
$user   = 'root';          // <-- ajusta si es distinto
$pass   = 'Root@123456';   // <-- ajusta si es distinto
$port   = 3306;

try {
    $pdo = new PDO(
        "mysql:host=$host;port=$port;dbname=$db;charset=utf8",
        $user,
        $pass,
        [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]
    );

    // ── Total de paquetes registrados ──────────────────────────────
    // Tabla real: "paquete" (singular)
    $paquetes = $pdo->query("SELECT COUNT(*) FROM paquete")->fetchColumn();

    // ── Rutas activas ───────────────────────────────────────────────
    // Tabla real: "ruta", el estado vive en el catálogo "estado_ruta"
    // Valores reales del catálogo: Planificada / En curso / Finalizada
    $rutas = $pdo->query("
        SELECT COUNT(*) 
        FROM ruta r
        INNER JOIN estado_ruta er ON r.id_estado_ruta = er.id_estado_ruta
        WHERE er.nombre_estado_ruta = 'En curso'
    ")->fetchColumn();

    // ── Bodegas registradas ──────────────────────────────────────────
    // La tabla "bodega" no tiene columna de estado, así que es el total
    $bodegas = $pdo->query("SELECT COUNT(*) FROM bodega")->fetchColumn();

    // ── Repartidores en servicio ─────────────────────────────────────
    // No existe tabla "repartidores" ni tipo_empleado = 'Repartidor'
    // ("Repartidor" es un ROL, no un tipo de empleado). Los que reparten
    // son los empleados con tipo_empleado = 'Conductor' y estado 'Activo'
    $repartidores = $pdo->query("
        SELECT COUNT(*)
        FROM empleado e
        INNER JOIN tipo_empleado t ON e.id_tipo_empleado = t.id_tipo_empleado
        INNER JOIN estado_empleado ee ON e.id_estado_empleado = ee.id_estado_empleado
        WHERE t.nombre_tipo_empleado = 'Repartidor' AND ee.nombre_estado_empleado = 'Activo'
    ")->fetchColumn();

    echo json_encode([
        'success' => true,
        'data' => [
            'paquetes'     => (int)$paquetes,
            'rutas'        => (int)$rutas,
            'bodegas'      => (int)$bodegas,
            'repartidores' => (int)$repartidores
        ]
    ]);
} catch (PDOException $e) {
    http_response_code(500);
    echo json_encode(['success' => false, 'error' => $e->getMessage()]);
}
?>
