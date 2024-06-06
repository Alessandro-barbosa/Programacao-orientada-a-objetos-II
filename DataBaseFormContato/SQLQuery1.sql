Insert into Contato (contatoId, nome, numero) values ();

CREATE TABLE [dbo].[Contato]
(--chave primaria auto encrement
[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
[Nome] NVARCHAR(MAX),
[numero] NVARCHAR(MAX)
);

INSERT INTO Contato (Nome, numero) VALUES ('Cássio', '2798135555');
INSERT INTO Contato (Nome, numero) VALUES ('João', '2795959595');
INSERT INTO Contato (Nome, numero) VALUES ('Pedro', '8595955959');


select * from Contato;