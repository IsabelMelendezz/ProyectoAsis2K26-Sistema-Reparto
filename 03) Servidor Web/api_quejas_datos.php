<?php
// api_quejas_datos.php
// Entrega las listas necesarias para llenar los <select> del formulario de quejas:
// clientes y entregas (con su código de pedido).

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

    $clientes = $pdo->query("
        SELECT id_cliente, nombres_cliente, apellidos_cliente
        FROM cliente
        ORDER BY nombres_cliente
    ")->fetchAll(PDO::FETCH_ASSOC);

    $entregas = $pdo->query("
        SELECT e.id_entrega, pe.codigo_pedido, e.fecha_entrega
        FROM entrega e
        INNER JOIN pedido pe ON e.id_pedido = pe.id_pedido
        ORDER BY e.id_entrega DESC
    ")->fetchAll(PDO::FETCH_ASSOC);

    echo json_encode([
        'success' => true,
        'data' => [
            'clientes'  => $clientes,
            'entregas'  => $entregas
        ]
    ]);
} catch (PDOException $e) {
    http_response_code(500);
    echo json_encode(['success' => false, 'error' => $e->getMessage()]);
}
?>
