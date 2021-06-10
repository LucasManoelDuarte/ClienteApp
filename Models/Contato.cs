using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApp.Models
{
    public class Contato
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }

    //    CREATE TABLE cliente(
    //   codigo INTEGER PRIMARY KEY AUTOINCREMENT,
    //   clienteAtivo BOOLEAN,
    //   nome VARCHAR (200),
    //   telefone VARCHAR(30),
    //   municipio VARCHAR(150),
    //   dataContrato DATE,
    //   valorMensalContrato DECIMAL(17, 2),
    //   observacoes TEXT,
    //   dataInclusao DATETIME NOT NULL
    //);

    //CREATE TABLE contato(
    //   id INTEGER PRIMARY KEY AUTOINCREMENT,
    //   codigoCliente INTEGER REFERENCES cliente (codigo),
    //   nome VARCHAR (110),
    //   dataNascimento DATE,
    //   email VARCHAR(150),
    //   telefone VARCHAR(30),
    //   dataInclusao DATETIME NOT NULL
    //);
}
