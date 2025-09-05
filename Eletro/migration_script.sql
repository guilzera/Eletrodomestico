CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;
CREATE TABLE "Clientes" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Clientes" PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "Email" TEXT NOT NULL,
    "Telefone" TEXT NOT NULL,
    "Endereco" TEXT NOT NULL
);

CREATE TABLE "Eletrodomesticos" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Eletrodomesticos" PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "Marca" TEXT NOT NULL,
    "Modelo" TEXT NOT NULL,
    "NumeroSerie" TEXT NOT NULL,
    "ClienteId" INTEGER NOT NULL,
    CONSTRAINT "FK_Eletrodomesticos_Clientes_ClienteId" FOREIGN KEY ("ClienteId") REFERENCES "Clientes" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_Eletrodomesticos_ClienteId" ON "Eletrodomesticos" ("ClienteId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250905125837_Initial', '9.0.8');

COMMIT;

