using Entities;

namespace NetCoreWebApplication.Models
{
    public class HomePageViewModel
    {
        public List<Category> Categories { get; set; } //Category Listesi

        public List<Slider> Sliders { get; set; }//Slider Listesi

        public List<News> News { get; set; }//Haberler Listesi

        public List<Post> Posts { get; set; }//İçerik Listesi
    }
}
