-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17-Abr-2023 às 00:16
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gran_pao_db`
--
CREATE DATABASE IF NOT EXISTS `gran_pao_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `gran_pao_db`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cargo`
--

CREATE TABLE `cargo` (
  `id_cargo` int(2) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `cargo`
--

INSERT INTO `cargo` (`id_cargo`, `nome`, `status`, `data_cadastro`, `observacao`) VALUES
(1, 'SYSTEM ADMIN', b'1', '2023-03-30 20:07:07', 'DEFAULT ADMIN SYSTEM');

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE `categoria` (
  `id_categoria` int(2) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `categoria`
--

INSERT INTO `categoria` (`id_categoria`, `nome`, `status`, `data_cadastro`, `observacao`) VALUES
(1, 'Categoria', b'1', '2023-03-30 20:12:19', ''),
(2, 'Frios', b'1', '2023-04-03 19:21:15', ''),
(3, 'Gelados', b'1', '2023-04-03 19:21:21', ''),
(4, 'Bebidas', b'1', '2023-04-03 19:21:27', ''),
(5, 'Laticínios', b'1', '2023-04-03 19:21:34', ''),
(6, 'Confeitaria', b'1', '2023-04-03 19:21:43', ''),
(7, 'Pães', b'1', '2023-04-03 19:22:12', ''),
(8, 'Doces', b'1', '2023-04-03 19:22:19', ''),
(9, 'Bolos', b'1', '2023-04-03 19:24:57', ''),
(10, 'Pão de forma', b'1', '2023-04-03 19:25:06', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(5) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `sexo` char(1) NOT NULL,
  `estado_civil` varchar(20) NOT NULL,
  `data_nascimento` datetime NOT NULL,
  `cpf` char(14) DEFAULT NULL,
  `cnpj` char(18) DEFAULT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `telefone_celular` char(14) DEFAULT NULL,
  `telefone_residencial` char(13) DEFAULT NULL,
  `telefone_recado` char(14) DEFAULT NULL,
  `cep` char(9) NOT NULL,
  `endereco` varchar(70) NOT NULL,
  `numero` int(4) NOT NULL,
  `complemento` varchar(40) NOT NULL,
  `cidade` varchar(40) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `estado` char(2) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `departamento`
--

CREATE TABLE `departamento` (
  `id_departamento` int(2) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `departamento`
--

INSERT INTO `departamento` (`id_departamento`, `nome`, `status`, `data_cadastro`, `observacao`) VALUES
(1, 'SYSTEM ADMIN', b'1', '2023-03-30 20:07:07', 'DEFAULT ADMIN SYSTEM');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `id_fornecedor` int(5) NOT NULL,
  `razao_social` varchar(60) NOT NULL,
  `nome_fantasia` varchar(60) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `telefone_principal` char(14) NOT NULL,
  `telefone_recado` char(14) DEFAULT NULL,
  `cep` char(9) NOT NULL,
  `endereco` varchar(70) NOT NULL,
  `numero` int(4) NOT NULL,
  `cidade` varchar(40) NOT NULL,
  `cnpj` char(18) NOT NULL,
  `estado` char(2) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`id_fornecedor`, `razao_social`, `nome_fantasia`, `email`, `telefone_principal`, `telefone_recado`, `cep`, `endereco`, `numero`, `cidade`, `cnpj`, `estado`, `status`, `data_cadastro`, `observacao`) VALUES
(1, 'teste', 'slaaa', 'wenderson', '19', '12', '134', 'ruaa sla', 0, 'isksk', '12', 'SP', b'1', '0000-00-00 00:00:00', 'teste'),
(2, 'Renata Chocolate 2', 'Chocolate', '', '(44)4444-4444', '(43)4234-3243', '12321-321', 'end', 124, 'pira', '11.313.131/3131-31', 'AP', b'0', '2023-03-30 22:16:53', ''),
(3, 'Ruan sla', 'sss', '', '( 1)1341-3413', '', '13131-313', 'end', 124, 'pira', ' 1.131.231/3212-31', 'AL', b'1', '2023-03-30 22:17:21', ''),
(4, 'ra', 'nome', '', '(  )1212-1212', '', '  111-11', 'end', 124, 'cida', '13.131.331/3131-31', 'AM', b'1', '2023-03-30 22:20:18', ''),
(5, 'matheus', 'sla dkwjfkwj', 'wem@gmail.com', '(11)3131-3131', '(13)1313-1313', '13131-313', 'ruaa sla', 124, 'pira', '12.122.121/21  -', 'AM', b'1', '2023-03-31 01:05:26', ''),
(6, 'cristina', 'sla', '', '(1 )    -', '(1 )    -', '1    -', '11', 1, '1', '12.121.212/2121-', 'CE', b'0', '2023-03-31 01:05:44', ''),
(7, 'teste', '124', '', '(13)1313-1313', '(13)    -', '13   -', '13', 13, '13', '13.   .   /    -', 'CE', b'1', '2023-03-31 01:05:58', '1'),
(8, 'mds', '54', '547', '(5 )    -', '(54)7   -', '54   -', '54', 54, '54', '54.5  .   /    -', 'BA', b'1', '2023-03-31 01:06:06', '54'),
(9, 'Luan drogas', 'drogas luan', 'luan2@drogas.com', '(19)9884-8583', '', '13402-299', 'endereco', 124, 'pira', '13.131.313/1313-11', 'AM', b'1', '2023-03-31 20:22:39', ''),
(10, 'Luan drogas', 'drogas luan', 'luan2@drogas.com', '(19)9884-8583', '', '13402-299', 'endereco', 124, 'pira', '13.131.313/1313-11', 'AM', b'1', '2023-03-31 20:22:51', ''),
(11, 'Ruan sla', 'sss', '', '( 1)1341-3413', '', '13131-313', 'end', 124, 'pira', ' 1.131.231/3212-31', 'BA', b'1', '2023-03-31 20:23:07', ''),
(12, 'teste', '124', '', '(13)1313-1313', '(13)    -', '13   -', '13', 13, '13', '13.   .   /    -', 'CE', b'1', '2023-03-31 20:23:17', ''),
(13, 'Bruno Salgado 2', 'Salados Bruno 3', 'bruno@gmail.com1', '(22)2222-2222', '(33)3333-3333', '44444-444', 'Rio das pedras 3', 33, 'São paulo 3', '66.666.666/6666-66', 'AM', b'1', '2023-04-03 19:26:01', 'a'),
(14, 'Gregs Lanche', 'Lanche', '', '(12)1212-1212', '(13)1313-1313', '11212-121', 'Vila idependencia', 51, 'Sao paulo', '12.121.212/1212-12', 'SP', b'1', '2023-04-03 19:26:51', ''),
(15, 'Guilherme Churrus', 'Churros Gui', '', '(21)2121-2121', '(21)2121-2121', '13131-113', 'Bruno sla', 97, 'Piracicaba', '11.111.111/1111-11', 'SP', b'1', '2023-04-03 19:28:19', 'Melhor Churros de Pira, e big churros'),
(16, 'Pedro Ovo', 'ovo do pedro ', '', '(99)9999-9999', '(99)9999-9999', '13131-313', 'Oliviaaa bianco ', 506, 'Saopaulo ', '11.111.111/1111-11', 'SP', b'1', '2023-04-03 19:29:35', 'OBS');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id_funcionario` int(4) NOT NULL,
  `id_departamento` int(2) NOT NULL,
  `id_cargo` int(2) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `sexo` char(1) NOT NULL,
  `estado_civil` varchar(20) DEFAULT NULL,
  `data_nascimento` datetime NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `telefone_celular` char(14) DEFAULT NULL,
  `telefone_residencial` char(13) DEFAULT NULL,
  `telefone_recado` char(14) DEFAULT NULL,
  `cep` char(9) NOT NULL,
  `endereco` varchar(70) NOT NULL,
  `numero` int(4) NOT NULL,
  `complemento` varchar(40) DEFAULT NULL,
  `cidade` varchar(40) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `estado` char(2) NOT NULL,
  `salario` decimal(6,2) NOT NULL,
  `login` varchar(30) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `tipo_acesso` varchar(15) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`id_funcionario`, `id_departamento`, `id_cargo`, `nome`, `email`, `sexo`, `estado_civil`, `data_nascimento`, `cpf`, `rg`, `telefone_celular`, `telefone_residencial`, `telefone_recado`, `cep`, `endereco`, `numero`, `complemento`, `cidade`, `bairro`, `estado`, `salario`, `login`, `senha`, `tipo_acesso`, `status`, `data_cadastro`, `observacao`) VALUES
(1, 1, 1, 'SYSTEM ADMIN', ' ', '', ' ', '2023-03-30 20:07:08', '', ' ', '', '', '', '', ' ', 0, ' ', ' ', ' ', '', '0.00', 'admin', 'admin', 'admin', b'1', '2023-03-30 20:07:08', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `marca`
--

CREATE TABLE `marca` (
  `id_marca` int(3) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `marca`
--

INSERT INTO `marca` (`id_marca`, `nome`, `status`, `data_cadastro`, `observacao`) VALUES
(1, 'Teste', b'0', '2023-03-30 20:12:12', ''),
(2, 'Puma', b'1', '2023-04-03 19:16:50', ''),
(3, 'Italac', b'1', '2023-04-03 19:16:59', ''),
(4, 'Panco', b'1', '2023-04-03 19:17:09', ''),
(5, 'Negresco', b'1', '2023-04-03 19:17:14', ''),
(6, 'Nestle', b'0', '2023-04-03 19:17:19', ''),
(8, 'Lacta', b'1', '2023-04-03 19:18:25', ''),
(9, 'Nobre', b'1', '2023-04-03 19:18:29', ''),
(10, 'Skol', b'1', '2023-04-03 19:19:15', ''),
(11, 'Brahma', b'0', '2023-04-03 19:19:20', ''),
(12, 'Antarctica', b'1', '2023-04-03 19:19:25', ''),
(13, 'Itaipava', b'1', '2023-04-03 19:19:33', ''),
(14, 'Crystal', b'1', '2023-04-03 19:19:44', ''),
(15, 'Bohemia', b'1', '2023-04-03 19:19:51', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `id_produto` int(6) NOT NULL,
  `id_fornecedor` int(5) NOT NULL,
  `id_marca` int(3) NOT NULL,
  `id_categoria` int(2) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `estoque` int(5) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `valor_custo` decimal(8,2) DEFAULT NULL,
  `valor_venda` decimal(8,2) NOT NULL,
  `margem_lucro` int(3) DEFAULT NULL,
  `status` bit(1) DEFAULT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id_produto`, `id_fornecedor`, `id_marca`, `id_categoria`, `nome`, `estoque`, `data_cadastro`, `valor_custo`, `valor_venda`, `margem_lucro`, `status`, `observacao`) VALUES
(1, 1, 1, 1, 'Refri', 120, '2023-03-30 20:13:35', '120.00', '122.40', 2, b'1', 'osb'),
(2, 9, 1, 1, 'Lsd', 1000, '2023-04-03 19:13:37', '70.00', '140.00', 100, b'1', 'Drogas boa e barata'),
(3, 5, 11, 2, 'Presunto', 120, '2023-04-03 19:32:30', '120.00', '122.40', 2, b'1', ''),
(4, 5, 8, 6, 'Mortadela', 30, '2023-04-03 19:32:51', '200.00', '204.00', 2, b'1', ''),
(5, 14, 12, 4, 'Apresuntado', 630, '2023-04-03 19:33:15', '30.00', '30.60', 2, b'1', ''),
(6, 13, 12, 4, 'Salame', 300, '2023-04-03 19:33:30', '300.00', '390.00', 30, b'1', ''),
(7, 14, 2, 2, 'Sorvetes', 600, '2023-04-03 19:33:50', '90.00', '91.80', 2, b'1', ''),
(8, 10, 12, 2, 'Picolés', 300, '2023-04-03 19:34:07', '300.00', '306.00', 2, b'1', ''),
(9, 13, 9, 2, 'Refrigerantes', 60, '2023-04-03 19:34:25', '300.00', '306.00', 2, b'1', ''),
(10, 13, 12, 4, 'Sucos', 600, '2023-04-03 19:34:41', '300.00', '312.00', 4, b'1', ''),
(11, 13, 12, 8, 'Leite', 88888, '2023-04-03 19:35:06', '900.00', '981.00', 9, b'1', ''),
(12, 8, 13, 6, 'Queijo', 69, '2023-04-03 19:35:21', '600.00', '654.00', 9, b'1', ''),
(13, 9, 14, 6, 'Iogurte', 1200, '2023-04-03 19:35:41', '9000.00', '9000.00', 0, b'1', ''),
(14, 15, 11, 8, 'wen', 120, '2023-04-16 17:13:12', '120.00', '122.40', 2, b'1', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_venda`
--

CREATE TABLE `produto_venda` (
  `id_produtovenda` int(4) NOT NULL,
  `id_produto` int(6) NOT NULL,
  `id_venda` int(6) NOT NULL,
  `data_cadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `id_venda` int(6) NOT NULL,
  `id_cliente` int(5) NOT NULL,
  `id_funcionario` int(4) NOT NULL,
  `credito` decimal(6,2) DEFAULT NULL,
  `dinheiro` decimal(6,2) DEFAULT NULL,
  `debito` decimal(6,2) DEFAULT NULL,
  `pix` decimal(6,2) DEFAULT NULL,
  `valor_venda` decimal(6,2) NOT NULL,
  `desconto` decimal(5,2) DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `obeservacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`id_cargo`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Índices para tabela `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`id_departamento`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`id_fornecedor`);

--
-- Índices para tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `login` (`login`),
  ADD KEY `id_departamento` (`id_departamento`),
  ADD KEY `id_cargo` (`id_cargo`);

--
-- Índices para tabela `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`),
  ADD KEY `id_fornecedor` (`id_fornecedor`),
  ADD KEY `id_marca` (`id_marca`),
  ADD KEY `id_categoria` (`id_categoria`);

--
-- Índices para tabela `produto_venda`
--
ALTER TABLE `produto_venda`
  ADD PRIMARY KEY (`id_produtovenda`),
  ADD KEY `id_produto` (`id_produto`),
  ADD KEY `id_venda` (`id_venda`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`id_venda`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_funcionario` (`id_funcionario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cargo`
--
ALTER TABLE `cargo`
  MODIFY `id_cargo` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_categoria` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `departamento`
--
ALTER TABLE `departamento`
  MODIFY `id_departamento` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `id_fornecedor` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id_funcionario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de tabela `produto_venda`
--
ALTER TABLE `produto_venda`
  MODIFY `id_produtovenda` int(4) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `id_venda` int(6) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`id_departamento`) REFERENCES `departamento` (`id_departamento`),
  ADD CONSTRAINT `funcionario_ibfk_2` FOREIGN KEY (`id_cargo`) REFERENCES `cargo` (`id_cargo`);

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`),
  ADD CONSTRAINT `produto_ibfk_3` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`);

--
-- Limitadores para a tabela `produto_venda`
--
ALTER TABLE `produto_venda`
  ADD CONSTRAINT `produto_venda_ibfk_1` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`),
  ADD CONSTRAINT `produto_venda_ibfk_2` FOREIGN KEY (`id_venda`) REFERENCES `venda` (`id_venda`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
