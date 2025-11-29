-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           9.3.0 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.11.0.7065
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para db_projetoengenhariadesoftware
CREATE DATABASE IF NOT EXISTS `db_projetoengenhariadesoftware` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_projetoengenhariadesoftware`;

-- Copiando estrutura para tabela db_projetoengenhariadesoftware.tb_clientes
CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'email não informado',
  `telefone` varchar(15) NOT NULL DEFAULT '0',
  `cpf` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_projetoengenhariadesoftware.tb_clientes: ~30 rows (aproximadamente)
DELETE FROM `tb_clientes`;
INSERT INTO `tb_clientes` (`id`, `nome`, `email`, `telefone`, `cpf`) VALUES
	(7, 'João Silva', 'joao.silva@email.com', '11987654321', '123.456.789-01'),
	(8, 'Maria Oliveira', 'maria.oliveira@email.com', '11976543210', '234.567.890-12'),
	(9, 'Carlos Souza', 'carlos.souza@email.com', '11965432109', '345.678.901-23'),
	(10, 'Fernanda Lima', 'fernanda.lima@email.com', '11954321098', '456.789.012-34'),
	(11, 'Lucas Pereira', 'lucas.pereira@email.com', '11943210987', '567.890.123-45'),
	(12, 'Ana Costa', 'ana.costa@email.com', '11932109876', '678.901.234-56'),
	(13, 'Roberto Santos', 'roberto.santos@email.com', '11921098765', '789.012.345-67'),
	(14, 'Juliana Almeida', 'juliana.almeida@email.com', '11910987654', '890.123.456-78'),
	(15, 'Rafael Martins', 'rafael.martins@email.com', '11999887766', '901.234.567-89'),
	(16, 'Patrícia Lima', 'patricia.lima@email.com', '11988776655', '012.345.678-90'),
	
	(17, 'João Silva', 'joao.silva@email.com', '11987654321', '123.456.789-01'),
	(18, 'Maria Oliveira', 'maria.oliveira@email.com', '11976543210', '234.567.890-12'),
	(19, 'Carlos Souza', 'carlos.souza@email.com', '11965432109', '345.678.901-23'),
	(20, 'Fernanda Lima', 'fernanda.lima@email.com', '11954321098', '456.789.012-34'),
	(21, 'Lucas Pereira', 'lucas.pereira@email.com', '11943210987', '567.890.123-45'),
	(22, 'Ana Costa', 'ana.costa@email.com', '11932109876', '678.901.234-56'),
	(23, 'Roberto Santos', 'roberto.santos@email.com', '11921098765', '789.012.345-67'),
	(24, 'Juliana Almeida', 'juliana.almeida@email.com', '11910987654', '890.123.456-78'),
	(25, 'Rafael Martins', 'rafael.martins@email.com', '11999887766', '901.234.567-89'),
	(26, 'Patrícia Lima', 'patricia.lima@email.com', '11988776655', '012.345.678-90'),
	
	(27, 'João Silva', 'joao.silva@email.com', '11987654321', '123.456.789-01'),
	(28, 'Maria Oliveira', 'maria.oliveira@email.com', '11976543210', '234.567.890-12'),
	(29, 'Carlos Souza', 'carlos.souza@email.com', '11965432109', '345.678.901-23'),
	(30, 'Fernanda Lima', 'fernanda.lima@email.com', '11954321098', '456.789.012-34'),
	(31, 'Lucas Pereira', 'lucas.pereira@email.com', '11943210987', '567.890.123-45'),
	(32, 'Ana Costa', 'ana.costa@email.com', '11932109876', '678.901.234-56'),
	(33, 'Roberto Santos', 'roberto.santos@email.com', '11921098765', '789.012.345-67'),
	(34, 'Juliana Almeida', 'juliana.almeida@email.com', '11910987654', '890.123.456-78'),
	(35, 'Rafael Martins', 'rafael.martins@email.com', '11999887766', '901.234.567-89'),
	(36, 'Patrícia Lima', 'patricia.lima@email.com', '11988776655', '012.345.678-90'),
	(38, 'Juan Antony', 'juan@email.com', '(83) 988776655', '123.123.123-45');

-- Copiando estrutura para tabela db_projetoengenhariadesoftware.tb_produtos
CREATE TABLE IF NOT EXISTS `tb_produtos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_projetoengenhariadesoftware.tb_produtos: ~45 rows (aproximadamente)
DELETE FROM `tb_produtos`;
INSERT INTO `tb_produtos` (`id`, `nome`, `preco`) VALUES
	(6, 'Notebook Dell Inspiron 15', 3500.00),
	(7, 'Smartphone Samsung Galaxy S21', 4200.00),
	(8, 'Monitor LG 27" Full HD', 1200.00),
	(9, 'Teclado Mecânico Razer', 500.00),
	(10, 'Mouse Logitech G Pro', 250.00),
	(11, 'SSD Kingston 512GB', 400.00),
	(12, 'Placa de Vídeo NVIDIA RTX 3060', 3000.00),
	(13, 'Fone de Ouvido Bluetooth Sony', 600.00),
	(14, 'Impressora HP LaserJet Pro', 800.00),
	(15, 'Cadeira Gamer DXRacer', 1500.00),
	(16, 'Mousepad XXL Corsair', 150.00),
	(17, 'Webcam Logitech C920', 350.00),
	(18, 'Caixa de Som JBL Flip 5', 650.00),
	(19, 'Fonte Corsair 750W', 700.00),
	(20, 'Memória RAM 16GB Corsair', 600.00),
	(21, 'Notebook Dell Inspiron 15', 3500.00),
	(22, 'Smartphone Samsung Galaxy S21', 4200.00),
	(23, 'Monitor LG 27" Full HD', 1200.00),
	(24, 'Teclado Mecânico Razer', 500.00),
	(25, 'Mouse Logitech G Pro', 250.00),
	(26, 'SSD Kingston 512GB', 400.00),
	(27, 'Placa de Vídeo NVIDIA RTX 3060', 3000.00),
	(28, 'Fone de Ouvido Bluetooth Sony', 600.00),
	(29, 'Impressora HP LaserJet Pro', 800.00),
	(30, 'Cadeira Gamer DXRacer', 1500.00),
	(31, 'Mousepad XXL Corsair', 150.00),
	(32, 'Webcam Logitech C920', 350.00),
	(33, 'Caixa de Som JBL Flip 5', 650.00),
	(34, 'Fonte Corsair 750W', 700.00),
	(35, 'Memória RAM 16GB Corsair', 600.00),
	(36, 'Notebook Dell Inspiron 15', 3500.00),
	(37, 'Smartphone Samsung Galaxy S21', 4200.00),
	(38, 'Monitor LG 27" Full HD', 1200.00),
	(39, 'Teclado Mecânico Razer', 500.00),
	(40, 'Mouse Logitech G Pro', 250.00),
	(41, 'SSD Kingston 512GB', 400.00),
	(42, 'Placa de Vídeo NVIDIA RTX 3060', 3000.00),
	(43, 'Fone de Ouvido Bluetooth Sony', 600.00),
	(44, 'Impressora HP LaserJet Pro', 800.00),
	(45, 'Cadeira Gamer DXRacer', 1500.00),
	(46, 'Mousepad XXL Corsair', 150.00),
	(47, 'Webcam Logitech C920', 350.00),
	(48, 'Caixa de Som JBL Flip 5', 650.00),
	(49, 'Fonte Corsair 750W', 700.00),
	(50, 'Memória RAM 16GB Corsair', 600.00);

-- Copiando estrutura para tabela db_projetoengenhariadesoftware.tb_vendas
CREATE TABLE IF NOT EXISTS `tb_vendas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ID_Cliente` int NOT NULL DEFAULT '0',
  `ID_Produto` int NOT NULL DEFAULT '0',
  `quantidade` int NOT NULL DEFAULT '0',
  `dataVenda` date NOT NULL DEFAULT (now()),
  PRIMARY KEY (`id`),
  KEY `FK__tb_clientes` (`ID_Cliente`),
  KEY `FK__tb_produtos` (`ID_Produto`),
  CONSTRAINT `FK__tb_clientes` FOREIGN KEY (`ID_Cliente`) REFERENCES `tb_clientes` (`id`),
  CONSTRAINT `FK__tb_produtos` FOREIGN KEY (`ID_Produto`) REFERENCES `tb_produtos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_projetoengenhariadesoftware.tb_vendas: ~16 rows (aproximadamente)
DELETE FROM `tb_vendas`;
INSERT INTO `tb_vendas` (`id`, `ID_Cliente`, `ID_Produto`, `quantidade`, `dataVenda`) VALUES
	(69, 18, 8, 1, '2025-02-02'),
	(70, 9, 9, 1, '2023-11-03'),
	(71, 10, 10, 1, '2023-11-04'),
	(72, 11, 11, 3, '2023-11-05'),
	(73, 12, 12, 1, '2023-11-06'),
	(74, 13, 13, 2, '2023-11-07'),
	(75, 14, 14, 1, '2023-11-08'),
	(76, 15, 15, 1, '2023-11-09'),
	(77, 16, 16, 1, '2023-11-10'),
	(78, 17, 17, 2, '2023-11-11'),
	(79, 18, 18, 1, '2023-11-12'),
	(80, 19, 19, 1, '2023-11-13'),
	(81, 20, 20, 1, '2023-11-14'),
	(82, 21, 21, 1, '2023-11-15'),
	(83, 22, 19, 1, '2025-02-02'),
	(84, 11, 8, 1, '2025-02-02');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
