using PayAndGoClone.Models;
using System.Collections.ObjectModel;

namespace PayAndGoClone.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Filter> Filters { get; set; }
        public ObservableCollection<Banner> Banners { get; set; }
        public ObservableCollection<ItemsGroup> ItemsGroups { get; set; }

        public MainPageViewModel()
        {
            CreateFilters();
            CreateBanners();
            CreateItemsGroups();
        }

        private void CreateFilters()
        {
            Filters = new ObservableCollection<Filter>()
            {
                new Filter()
                {
                    ImageUrl = "https://imagens.canaltech.com.br/produto/1540320629-3958-principal-m.png",
                    Description = "Celulares"
                },
                new Filter()
                {
                    ImageUrl = "https://avontsplay.files.wordpress.com/2016/08/consoles.png?w=748",
                    Description = "Consoles"
                },
                new Filter()
                {
                    ImageUrl = "https://img.terabyteshop.com.br/produto/g/placa-de-video-galax-geforce-rtx-2060-1-click-oc-6gb-26nrl7hpx7oc-gddr6-pci-exp_63377.png",
                    Description = "Placas de Vídeo"
                },
                new Filter()
                {
                    ImageUrl = "https://cdn.pixabay.com/photo/2014/04/02/10/13/notebook-303161_1280.png",
                    Description = "Notebooks"
                },
                new Filter()
                {
                    ImageUrl = "https://i.pinimg.com/originals/85/93/98/8593980719357abc021e94c5524207ca.png",
                    Description = "Macbooks"
                },

            };
        }

        private void CreateBanners()
        {
            Banners = new ObservableCollection<Banner>()
            {
                new Banner()
                {
                    ImageUrl = "Banner.png"
                },
                new Banner()
                {
                    ImageUrl = "Banner.png"
                },
                new Banner()
                {
                    ImageUrl = "Banner.png"
                }
            };
        }

        private void CreateItemsGroups()
        {
            ItemsGroups = new ObservableCollection<ItemsGroup>();

            var itemsGroupNewProduct = new ItemsGroup("Novos Produtos", "Produtos mais recentes");
            var itemCollectionNewProduct = new ItemsCollection();
            var item1NewProduct = new Items("https://imagens.canaltech.com.br/produto/1553634130-6429-principal-m.png", "Playstation 4 Pro", 2500, false, 0, 0);
            var item2NewProduct = new Items("https://png.pngitem.com/pimgs/s/115-1159479_xbox-png-transparent-image-xbox-one-x-digital.png", "Xbox One X", 3000, true, 67, 1000);
            itemCollectionNewProduct.Add(item1NewProduct);
            itemCollectionNewProduct.Add(item2NewProduct);
            itemsGroupNewProduct.Add(itemCollectionNewProduct);

            var itemsGroupBlackFriday = new ItemsGroup("Black Friday 2020", "Produtos da black friday");
            var itemCollectionBlackFriday = new ItemsCollection();
            var item1BlackFriday = new Items("https://imagens.canaltech.com.br/produto/1553634130-6429-principal-m.png", "Playstation 4 Pro", 2500, false, 0, 0);
            var item2BlackFriday = new Items("https://png.pngitem.com/pimgs/s/115-1159479_xbox-png-transparent-image-xbox-one-x-digital.png", "Xbox One X", 3000, true, 67, 1000);
            var item3BlackFriday = new Items("https://imagens.canaltech.com.br/produto/1553634130-6429-principal-m.png", "Playstation 4 Pro", 2500, false, 0, 0);
            var item4BlackFriday = new Items("https://png.pngitem.com/pimgs/s/115-1159479_xbox-png-transparent-image-xbox-one-x-digital.png", "Xbox One X", 3000, true, 67, 1000);
            itemCollectionBlackFriday.Add(item1BlackFriday);
            itemCollectionBlackFriday.Add(item2BlackFriday);
            itemCollectionBlackFriday.Add(item3BlackFriday);
            itemCollectionBlackFriday.Add(item4BlackFriday);
            itemsGroupBlackFriday.Add(itemCollectionBlackFriday);

            ItemsGroups.Add(itemsGroupNewProduct);
            ItemsGroups.Add(itemsGroupBlackFriday);
        }
    }
}