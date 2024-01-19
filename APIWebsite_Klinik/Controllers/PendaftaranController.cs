using APIWebsite_Klinik.DAL;
using APIWebsite_Klinik.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIWebsite_Klinik.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PendaftaranController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PendaftaranController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPendaftaran()
        {
            try
            {
                var listPendaftaran = _context.TBL_PENDAFTARANs.ToList();
                if (listPendaftaran.Count == 0)
                {
                    return NotFound("Tidak ada pendaftaran");
                }
                return Ok(listPendaftaran);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //Get Details pendaftaran
        [HttpGet("id")]
        public IActionResult GetDetailsPendaftaran(int id)
        {
            try
            {
                var pendfaftaran = _context.TBL_PENDAFTARANs.Include(a => a.PASIEN)
                    .ThenInclude(b => b.ALAMAT).FirstOrDefault(c => c.ID_PENDAFTARAN == id);
                if (pendfaftaran == null)
                {
                    return NotFound($"Pendaftaran Id {id} tidak ditemukan");
                }
                return Ok(pendfaftaran);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get Details By ID Pasien
        [HttpGet("NamaPasien")]
        public IActionResult GetDetailByidPasien(string namaPasien)
        {
            try
            {
                var pendaftaran = _context.TBL_PENDAFTARANs.Include(a => a.PASIEN)
                                        .ThenInclude(b => b.ALAMAT).FirstOrDefault(c => c.NAMA_PASIEN == namaPasien);
                if (pendaftaran == null)
                {
                    return NotFound($"Pendaftaran Pasien {namaPasien} tidak ditemukan");
                }
                return Ok(pendaftaran);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult PostPendaftaranPasienBaru(TBL_PENDAFTARAN modelPendafataran)
        {
            try
            {
                _context.Add(modelPendafataran);
                _context.SaveChanges();
                return Ok("Pasien Baru Berhasil didafarkan!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("id_pasien")]
        public IActionResult PostPendaftaran(TBL_PENDAFTARAN model)
        {
            try
            {
                var pendaftaran = _context.TBL_PENDAFTARANs.Find(model.ID_PENDAFTARAN);
                if (pendaftaran == null)
                    return NotFound($"Pendaftaan ID {model.ID_PENDAFTARAN} tidak ditemukan");

                if(model.PASIEN != null)
                {
                    _context.TBL_PASIENs.Remove(model.PASIEN);
                }
                _context.Add(model);
                _context.SaveChanges();
                return Ok("Pendaftaran Pasien Berhasil");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult updatePendaftaran(TBL_PENDAFTARAN model)
        {
            if(model == null || model.ID_PENDAFTARAN == 0)
            {
                if(model == null)
                {
                    return BadRequest("Data Pendaftaran Tidak Valid");
                }
                else if(model.ID_PENDAFTARAN == 0)
                {
                    return BadRequest($"ID Pendaftaran {model.ID_PENDAFTARAN} adalah Invalid");
                }
            }

            try
            {
                var pendaftaran = _context.TBL_PENDAFTARANs.Find(model.ID_PENDAFTARAN);
                var dataPasien = _context.TBL_PASIENs.Find(model.ID_PASIEN);
                if (pendaftaran == null)
                {
                    return NotFound($"Pendafataran dengan ID {model.ID_PENDAFTARAN} tidak ditemukan");
                }

                pendaftaran.ID_PENDAFTARAN = model.ID_PENDAFTARAN;
                pendaftaran.ID_PASIEN = model.ID_PASIEN;
                pendaftaran.ID_ADMIN = model.ID_ADMIN;
                pendaftaran.PASIEN = model.PASIEN;
                
                //Data Pasien
                //dataPasien.NAMA_PASIEN = model.PASIEN.NAMA_PASIEN;
                //dataPasien.AGAMA = model.PASIEN.AGAMA;

                pendaftaran.NAMA_PASIEN = model.NAMA_PASIEN;
                pendaftaran.UNIT_DITUJU = model.UNIT_DITUJU;
                pendaftaran.ID_TINDAKAN = model.ID_TINDAKAN;
                pendaftaran.KONSULTASI = model.KONSULTASI;
                pendaftaran.TANGGAL_BEROBAT = model.TANGGAL_BEROBAT;
                pendaftaran.STATUS_FORM = model.STATUS_FORM;
                pendaftaran.DIBUAT_OLEH = model.DIBUAT_OLEH;
                pendaftaran.TANGGAL_DIBUAT = model.TANGGAL_DIBUAT;
                pendaftaran.DIUPDATE_OLEH = model.DIUPDATE_OLEH;
                pendaftaran.TANGGAL_UPDATE = model.TANGGAL_UPDATE;
                pendaftaran.ID_OBAT = model.ID_OBAT;
                pendaftaran.REKAM_MEDIS = model.REKAM_MEDIS;

                _context.SaveChanges();

                return Ok("Update Pendaftaran Sukses!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeletePendaftaran(int id)
        {
            try
            {
                var pendaftaran = _context.TBL_PENDAFTARANs.Find(id);
                if (pendaftaran == null)
                {
                    return NotFound($"Id Pendaftaran {id} Tidak Ditemukan");
                }
                _context.TBL_PENDAFTARANs.Remove(pendaftaran);
                _context.SaveChanges();
                return Ok("Berhasil Menghapus data Pendafaran");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
