USE KlinikDatabase
GO


DROP TABLE IF EXISTS Tbl_Pendaftaran

CREATE TABLE Tbl_Pendaftaran (
  [ID_PENDAFTARAN] INTEGER IDENTITY(1,1) PRIMARY KEY,
  [ID_PASIEN] INT,
  [ID_ADMIN] INT,
  [NAMA_PASIEN] VARCHAR(255),
  [UNIT_DITUJU] integer,
  [ID_TINDAKAN] integer,
  [KONSULTASI] VARCHAR(255),
  [TANGGAL_BEROBAT] DATETIME,
  [STATUS_FORM] VARCHAR(20),
  [CREATED_BY] INT,
  [CREATED_DATE] DATETIME,
  [MODIFIED_BY] INT,
  [MODIFIED_DATE] DATETIME,
  [ID_OBAT] integer,
  [REKAM_MEDIS] VARCHAR(50)
)
GO