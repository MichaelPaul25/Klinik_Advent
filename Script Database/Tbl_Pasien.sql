USE KlinikDatabase
GO

DROP TABLE IF EXISTS Tbl_Pasien

CREATE TABLE Tbl_Pasien(
    [ID_PASIEN] INTEGER IDENTITY(1,1) PRIMARY KEY,
  [REKAM_MEDIS] VARCHAR(50),
  [NAMA_PASIEN] VARCHAR(100),
  [ALAMAT] VARCHAR(255),
  [JENIS_KELAMIN] VARCHAR(20),
  [AGAMA] VARCHAR(20),
  [PEKERJAAN] VARCHAR(20),
  [STATUS_KAWIN] VARCHAR(255),
  [NOMOR_TELEPON] VARCHAR(20),
  [EMAIL_PASIEN] VARCHAR(50),
  [TEMPAT_LAHIR] VARCHAR(50),
  [TANGGAL_LAHIR] DATETIME,
  [REGISTER_BY] INTEGER,
  [MODIFIED_BY] INTEGER
)
GO