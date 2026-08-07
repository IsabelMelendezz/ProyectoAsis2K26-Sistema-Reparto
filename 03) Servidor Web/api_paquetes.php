<?php
// api_paquetes.php
// Conexión al nodo maestro replicado (10.10.10.27)

header('Content-Type: application/json');
header('Access-Control-Allow-Origin: *');

$host   = '20.10.10.26';
$db     = 'sistema_reparto';
$user   = 'root';          // <-- ajusta
$pass   = 'Root@123456';   // <-- ajusta
$port   = 3306;

try {
    $pdo = new PDO(
        "mysql:host=$host;port=$port;dbname=$db;charset=utf8",
        $user,
        $pass,
        [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]
    );

    $stmt = $pdo->query("
        SELECT
            p.id_paquete       AS Id_Paquete,
            p.codigo_rastreo_paquete   AS Codigo_Rastreo,
            pe.codigo_pedido   AS Pedido,
            p.descripcion_paquete      AS Descripcion,
            p.peso_paquete             AS Peso,
            p.fragil_paquete           AS Fragil,
            p.valor_declarado_paquete  AS Valor_Declarado,
            p.estado_paquete           AS Estado
        FROM paquete p
        INNER JOIN pedido pe ON p.id_pedido = pe.id_pedido
        ORDER BY p.id_paquete
    ");
    $rows = $stmt->fetchAll(PDO::FETCH_ASSOC);

    echo json_encode(['success' => true, 'data' => $rows]);
} catch (PDOException $e) {
    http_response_code(500);
    echo json_encode(['success' => false, 'error' => $e->getMessage()]);
}
?>
