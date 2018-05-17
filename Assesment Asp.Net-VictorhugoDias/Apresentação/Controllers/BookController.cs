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
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Books").Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var lista = JsonConvert.DeserializeObject<List<BookViewModel>>(json);

                    return View(lista);
                }

            }

            return View();
        }


        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Books/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var livros = JsonConvert.DeserializeObject<BookViewModel>(json);

                    return View(livros);
                }

            }

            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Book livro)
        {
            try
            {
                {
                    using (var apiClient = new HttpClient())
                    {
                        var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                        apiClient.BaseAddress = new Uri("http://localhost:51345/");
                        apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                        var response = await apiClient.PostAsJsonAsync("/api/Books", livro);

                        return RedirectToAction("Index");

                    }
                }


            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Books/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var livros = JsonConvert.DeserializeObject<BookViewModel>(json);

                    return View(livros);
                }

                return View();
            }
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, BookViewModel livrosView)
        {
            try
            {
                {
                    using (var apiClient = new HttpClient())
                    {
                        var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                        apiClient.BaseAddress = new Uri("http://localhost:51345/");
                        apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                        var response = await apiClient.PutAsJsonAsync("/api/Books/" + id, livrosView);

                        return RedirectToAction("Index");

                    }
                }


            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            using (var apiClient = new HttpClient())
            {
                var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
                apiClient.BaseAddress = new Uri("http://localhost:51345/");
                apiClient.DefaultRequestHeaders.Accept.Add(mediaType);
                var response = apiClient.GetAsync("/api/Books/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var livros = JsonConvert.DeserializeObject<BookViewModel>(json);

                    return View(livros);
                }

            }

            return View();
        }


        // POST: Book/Delete/5
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
                    var response = await apiClient.DeleteAsync("/api/Books/" + id);

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
