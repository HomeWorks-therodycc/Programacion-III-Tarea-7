BEGIN TRANSACTION;
DROP TABLE IF EXISTS "provincias";
CREATE TABLE IF NOT EXISTS "provincias" (
	"id"	INTEGER NOT NULL,
	"nombre"	TEXT NOT NULL,
	CONSTRAINT "PK_provincias" PRIMARY KEY("id" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "vacunados";
CREATE TABLE IF NOT EXISTS "vacunados" (
	"id"	INTEGER NOT NULL,
	"apellido"	TEXT NOT NULL,
	"cedula"	TEXT NOT NULL,
	"nombre"	TEXT NOT NULL,
	"provincia_id"	INTEGER NOT NULL,
	"telefono"	TEXT NOT NULL,
	"vacuna1_fecha"	TEXT,
	"vacuna1_id"	INTEGER,
	"vacuna2_fecha"	TEXT,
	"vacuna2_id"	INTEGER,
	CONSTRAINT "FK_vacunados_provincias_provincia_id" FOREIGN KEY("provincia_id") REFERENCES "provincias"("id") ON DELETE RESTRICT,
	CONSTRAINT "FK_vacunados_vacunas_vacuna1_id" FOREIGN KEY("vacuna1_id") REFERENCES "vacunas"("id") ON DELETE RESTRICT,
	CONSTRAINT "FK_vacunados_vacunas_vacuna2_id" FOREIGN KEY("vacuna2_id") REFERENCES "vacunas"("id") ON DELETE RESTRICT,
	CONSTRAINT "PK_vacunados" PRIMARY KEY("id" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "vacunas";
CREATE TABLE IF NOT EXISTS "vacunas" (
	"id"	INTEGER NOT NULL,
	"marca"	TEXT NOT NULL,
	"cantidad_restante"	INTEGER NOT NULL,
	"cantidad_total"	INTEGER,
	CONSTRAINT "PK_vacunas" PRIMARY KEY("id" AUTOINCREMENT)
);
INSERT INTO "provincias" ("id","nombre") VALUES (1,'Azua'),
 (2,'Bahoruco'),
 (3,'Barahona'),
 (4,'Dajabón'),
 (5,'Distrito Nacional'),
 (6,'Duarte'),
 (7,'Elías Piña'),
 (8,'El Seibo'),
 (9,'Espaillat'),
 (10,'Hato Mayor'),
 (11,'Hermanas Mirabal'),
 (12,'Independencia'),
 (13,'La Altagracia'),
 (14,'La Romana'),
 (15,'La Vega'),
 (16,'María Trinidad Sánchez'),
 (17,'Monseñor Nouel'),
 (18,'Monte Cristi'),
 (19,'Monte Plata'),
 (20,'Pedernales'),
 (21,'Peravia'),
 (22,'Puerto Plata'),
 (23,'Samaná'),
 (24,'San Cristóbal'),
 (25,'San José de Ocoa'),
 (26,'San Juan'),
 (27,'San Pedro de Macorís'),
 (28,'Sánchez Ramírez'),
 (29,'Santiago'),
 (30,'Santiago Rodríguez'),
 (31,'Santo Domingo'),
 (32,'Valverde');
INSERT INTO "vacunas" ("id","marca","cantidad_restante","cantidad_total") VALUES (1,'Astrazeneca',10000000,10000000),
 (2,'Pfizer',7900000,7900000);
DROP INDEX IF EXISTS "IX_vacunados_cedula";
CREATE UNIQUE INDEX IF NOT EXISTS "IX_vacunados_cedula" ON "vacunados" (
	"cedula"
);
DROP INDEX IF EXISTS "IX_vacunados_provincia_id";
CREATE INDEX IF NOT EXISTS "IX_vacunados_provincia_id" ON "vacunados" (
	"provincia_id"
);
DROP INDEX IF EXISTS "IX_vacunados_vacuna1_id";
CREATE INDEX IF NOT EXISTS "IX_vacunados_vacuna1_id" ON "vacunados" (
	"vacuna1_id"
);
DROP INDEX IF EXISTS "IX_vacunados_vacuna2_id";
CREATE INDEX IF NOT EXISTS "IX_vacunados_vacuna2_id" ON "vacunados" (
	"vacuna2_id"
);
DROP TRIGGER IF EXISTS "auto_vacunas_restantes_delete";
CREATE TRIGGER auto_vacunas_restantes_delete
   AFTER DELETE
   ON vacunados
BEGIN
	update vacunas set cantidad_restante = cantidad_restante + 1 where vacunas.id == old.vacuna1_id;
	update vacunas set cantidad_restante = cantidad_restante + 1 where vacunas.id == old.vacuna2_id;
END;
DROP TRIGGER IF EXISTS "auto_vacunas_restantes_insert";
CREATE TRIGGER auto_vacunas_restantes_insert
   AFTER INSERT
   ON vacunados
BEGIN
	update vacunas set cantidad_restante = cantidad_restante - 1 where vacunas.id == new.vacuna1_id;
	update vacunas set cantidad_restante = cantidad_restante - 1 where vacunas.id == new.vacuna2_id;
END;
DROP TRIGGER IF EXISTS "auto_vacunas_restantes_update";
CREATE TRIGGER auto_vacunas_restantes_update
   AFTER UPDATE
   ON vacunados
BEGIN
	update vacunas set cantidad_restante = cantidad_restante + 1 where vacunas.id == old.vacuna1_id;
	update vacunas set cantidad_restante = cantidad_restante - 1 where vacunas.id == new.vacuna1_id;
	update vacunas set cantidad_restante = cantidad_restante + 1 where vacunas.id == old.vacuna2_id;
	update vacunas set cantidad_restante = cantidad_restante - 1 where vacunas.id == new.vacuna2_id;
END;
COMMIT;
