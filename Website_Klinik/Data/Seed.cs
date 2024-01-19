using Microsoft.AspNetCore.Identity;
using System;
using System.Diagnostics;
using System.Net;
using Website_Klinik.Models;

namespace Website_Klinik.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Seeding Tbl_Alamat
                //if (!context.TBL_ALAMATs.Any())
                //{
                //    context.TBL_ALAMATs.AddRange(new List<TBL_ALAMAT>()
                //    {
                //        new TBL_ALAMAT()
                //        {
                //            JALAN_PERUMAHAN = "Tiban Indah",
                //            RT_RW = "02/11",
                //            KECAMATAN = "Sekupang",
                //            KABUPATEN = "",
                //            KOTA  = "Batam",
                //            PROVINSI = "Kepulauan Riau"
                //         },
                //        new TBL_ALAMAT()
                //        {
                //            JALAN_PERUMAHAN = "Marina Mas",
                //            RT_RW = "01/05",
                //            KECAMATAN = "Sekupang",
                //            KABUPATEN = "",
                //            KOTA  = "Batam",
                //            PROVINSI = "Kepulauan Riau"
                //        },
                //        new TBL_ALAMAT()
                //        {
                //            JALAN_PERUMAHAN = "Baloi Mas",
                //            RT_RW = "05/01",
                //            KECAMATAN = "Batam Kota",
                //            KABUPATEN = "",
                //            KOTA  = "Batam",
                //            PROVINSI = "Kepulauan Riau"
                //        },
                //        new TBL_ALAMAT()
                //        {
                //            JALAN_PERUMAHAN = "Anggrek Mas",
                //            RT_RW = "01/02",
                //            KECAMATAN = "Batam Kota",
                //            KABUPATEN = "",
                //            KOTA  = "Batam",
                //            PROVINSI = "Kepulauan Riau"
                //        }
                //    });
                //    context.SaveChanges();
                //}
                //Seeding Tbl_Pendaftaran
                if (!context.TBL_PENDAFTARANs.Any())
                {
                    context.TBL_PENDAFTARANs.AddRange(new List<TBL_PENDAFTARAN>()
                    {
                        //new TBL_PENDAFTARAN()
                        //{
                        //      ID_PASIEN = 2,
                        //      ID_ADMIN = 1,
                        //      PASIEN = new TBL_PASIEN(){},
                        //      ALAMAT = new TBL_ALAMAT(){},
                        //      NAMA_PASIEN = "Sarah Situmorang",
                        //      UNIT_DITUJU = "Umum",
                        //      ID_TINDAKAN = "2",
                        //      KONSULTASI = "Ya",
                        //      TANGGAL_BEROBAT = DateTime.Now,
                        //      STATUS_FORM = "DRAFT",
                        //      DIBUAT_OLEH = "2",
                        //      TANGGAL_DIBUAT = DateTime.Now,
                        //      DIUPDATE_OLEH = "2",
                        //      TANGGAL_UPDATE = DateTime.Now,
                        //      ID_OBAT = 1,
                        //      REKAM_MEDIS = "RM-" + "UMUM-" + DateTime.Now.ToString()

                        //},
                        new TBL_PENDAFTARAN()
                        {
                            ID_PASIEN = 2,
                              ID_ADMIN = 1,
                              PASIEN = new TBL_PASIEN(){
                                  REKAM_MEDIS = "XX" + DateTime.Now,
                                  NAMA_PASIEN = "Nadine Situmorang",
                                  ALAMAT = new TBL_ALAMAT()
                                  {
                                      JALAN_PERUMAHAN = "Permata Laguna",
                                      RT_RW = "02/11",
                                      KECAMATAN = "Batu Aji",
                                      KABUPATEN = "",
                                      KOTA = "Batam",
                                      PROVINSI = "Kepulauan Riau"
                                  },
                                  JENIS_KELAMIN = "Perempuan",
                                  AGAMA = "Kristen",
                                  PEKERJAAN = "PNS",
                                  STATUS_KAWIN = "Belum Kawin",
                                  NOMOR_TELEPON = "82390801003",
                                  EMAIL_PASIEN = "user@gmail.com",
                                  TEMPAT_LAHIR = "Batam",
                                  TANGGAL_LAHIR = DateTime.Now,
                                  REGISTER_BY = "2",
                                  MODIFIED_BY = "1"
                              },
                              NAMA_PASIEN = "Nadine Situmorang",
                              UNIT_DITUJU = "Gigi",
                              ID_TINDAKAN = "1",
                              KONSULTASI = "Ya",
                              TANGGAL_BEROBAT = DateTime.Now,
                              STATUS_FORM = "PEMBAYARAN",
                              DIBUAT_OLEH = "2",
                              TANGGAL_DIBUAT = DateTime.Now,
                              DIUPDATE_OLEH = "2",
                              TANGGAL_UPDATE = DateTime.Now,
                              ID_OBAT = 1,
                              REKAM_MEDIS = "RM-"+ "GIGI-" + DateTime.Now.ToString()
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}
