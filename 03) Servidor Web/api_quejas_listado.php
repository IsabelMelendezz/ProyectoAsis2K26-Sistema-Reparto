<?php
// api_quejas_listado.php
// Devuelve las quejas guardadas, la más reciente primero,
// con el nombre del cliente y el código de pedido asociado.

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
            q.id_queja,
            q.tipo_queja,
            q.comentario_queja,
            q.calificacion_queja,
            q.fecha_queja,
            c.nombres_cliente        AS cliente_nombres,
            c.apellidos_cliente      AS cliente_apellidos,
            pe.codigo_pedido AS codigo_pedido
        FROM queja q
        INNER JOIN cliente c ON q.id_cliente = c.id_cliente
        INNER JOIN entrega e  ON q.id_entrega = e.id_entrega
        INNER JOIN pedido pe  ON e.id_pedido = pe.id_pedido
        ORDER BY q.id_queja DESC
    ");
    $rows = $stmt->fetchAll(PDO::FETCH_ASSOC);

    echo json_encode(['success' => true, 'data' => $rows]);
} catch (PDOException $e) {
    http_response_code(500);
    echo json_encode(['success' => false, 'error' => $e->getMessage()]);
}
?>
