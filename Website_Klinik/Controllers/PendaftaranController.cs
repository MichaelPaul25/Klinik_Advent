using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Website_Klinik.Data;
using Website_Klinik.Models;

namespace Website_Klinik.Controllers
{
    public class PendaftaranController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7188/api");
        private readonly HttpClient _client;

        public PendaftaranController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<TBL_PENDAFTARAN> tbl_pendaftaran = new List<TBL_PENDAFTARAN>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Pendaftaran/GetPendaftaran").Result;

            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                tbl_pendaftaran = JsonConvert.DeserializeObject<List<TBL_PENDAFTARAN>>(data);
            }

            return View(tbl_pendaftaran);
        }
        //public IActionResult Details(int id)
        //{
            //TBL_PENDAFTARAN Pendaftaran = _context.TBL_PENDAFTARANs.Include(a => a.PASIEN)
            //                                .ThenInclude(b =>b.ALAMAT).FirstOrDefault(c => c.ID_PENDAFTARAN == id);
            ////Pendaftaran = _context.TBL_PENDAFTARANs.Include(a => a.ALAMAT).FirstOrDefault();
            
            //if (Pendaftaran != null)
            //    return View(Pendaftaran);
            //else
            //    return View();
        //}


    }
}
