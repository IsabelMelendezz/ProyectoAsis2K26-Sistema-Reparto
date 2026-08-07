<?php
// api_guardar_queja.php
// Recibe el formulario de "Quejas" del sitio (POST en JSON) y lo inserta en la tabla queja.

header('Content-Type: application/json');
header('Access-Control-Allow-Origin: *');

$host   = '20.10.10.26';
$db     = 'sistema_reparto';
$user   = 'root';          // <-- ajusta
$pass   = 'Root@123456';   // <-- ajusta
$port   = 3306;

// Lee el cuerpo de la petición (JSON enviado desde fetch)
$input = json_decode(file_get_contents('php://input'), true);

$id_cliente   = $input['id_cliente']   ?? null;
$id_entrega   = $input['id_entrega']   ?? null;
$tipo         = trim($input['tipo'] ?? '');
$comentario   = trim($input['comentario'] ?? '');
$calificacion = $input['calificacion'] ?? null;

// Validación básica antes de tocar la base de datos
if (!$id_cliente || !$id_entrega || $tipo === '' || $comentario === '' || !$calificacion) {
    http_response_code(400);
    echo json_encode(['success' => false, 'error' => 'Todos los campos son obligatorios.']);
    exit;
}

if ($calificacion < 1 || $calificacion > 5) {
    http_response_code(400);
    echo json_encode(['success' => false, 'error' => 'La calificación debe estar entre 1 y 5.']);
    exit;
}

try {
    $pdo = new PDO(
        "mysql:host=$host;port=$port;dbname=$db;charset=utf8",
        $user,
        $pass,
        [PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION]
    );

    $stmt = $pdo->prepare("
        INSERT INTO queja (id_entrega, id_cliente, tipo_queja, comentario_queja, calificacion_queja, fecha_queja)
        VALUES (:id_entrega, :id_cliente, :tipo, :comentario, :calificacion, CURDATE())
    ");
    $stmt->execute([
        ':id_entrega'   => $id_entrega,
        ':id_cliente'   => $id_cliente,
        ':tipo'         => $tipo,
        ':comentario'   => $comentario,
        ':calificacion' => $calificacion
    ]);

    echo json_encode(['success' => true, 'id_queja' => $pdo->lastInsertId()]);
} catch (PDOException $e) {
    http_response_code(500);
    echo json_encode(['success' => false, 'error' => $e->getMessage()]);
}
?>
