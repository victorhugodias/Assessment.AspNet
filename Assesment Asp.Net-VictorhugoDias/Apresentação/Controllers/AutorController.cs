using Domain;
using Newtonsoft.Json;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{

    [Authorize]
    [RequireHttps]
    public class AutorController : Controller
    {
        // GET: Autor
        public ActionResult Index()
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Autors").Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var lista = JsonConvert.DeserializeObject<List<AutorViewModel>>(json);

                    return View(lista);
                }

            }

            return View();
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Autors/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var autor = JsonConvert.DeserializeObject<AutorViewModel>(json);

                    return View(autor);
                }

            }

            return View();
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Autor autor)
        {
            try
            {
                using (var apiClient = new HttpClient())
                {
                    var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                    apiClient.BaseAddress = new Uri("http://localhost:51345/");
                    apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                    var response = await apiClient.PostAsJsonAsync("/api/Autors", autor);


                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }



        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Autors/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var autor = JsonConvert.DeserializeObject<AutorViewModel>(json);

                    return View(autor);
                }

            }

            return View();
        }

        // POST: Autor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, AutorViewModel Autor)
        {

            Autor autor = new Autor()
            {
                AutorId = Autor.AutorId,
                Livros = Autor.Livros,
                Nome = Autor.Nome,
                Sobrenome = Autor.Sobrenome
            };


            try
            {

                using (var apiClient = new HttpClient())
                {
                    var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                    apiClient.BaseAddress = new Uri("http://localhost:51345/");
                    apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                    await apiClient.PutAsJsonAsync("/api/Autors/" + id, autor);

                    return RedirectToAction("Index");
                }
            }

            catch
            {
                return View();
            }

        }

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Autors/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var autor = JsonConvert.DeserializeObject<AutorViewModel>(json);

                    return View(autor);
                }

            }

            return View();
        }

        // POST: Autor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, FormCollection collection)
        {

            try
            {
                using (var apiClient = new HttpClient())
                {
                    var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                    apiClient.BaseAddress = new Uri("http://localhost:51345/");
                    apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                    var response = await apiClient.DeleteAsync("/api/Autors/" + id);


                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
