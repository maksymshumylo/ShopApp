using Shop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        private int _selectedId;

        private int _priceId;

        public int PriceId
        {
            get => _priceId;
            set
            {
                SortByPrice(value);
            }
        }

        private void SortByPrice(int value)
        {
            IEnumerable<ProductsBase> list = null;
            CollectionToView.Clear();


            switch (SelectedId)
            {
                case 0:
                    list = Products;
                    break;
                case 1:
                    list = Products.Where(e => e.Category == "Clothes");
                    break;
                case 2:
                    list = Products.Where(e => e.Category == "Sport");
                    break;
                case 3:
                    list = Products.Where(e => e.Category == "Tech");
                    break;
            }

            switch (value)
            {
                case 0:
                    list = list.OrderByDescending(e => e.Price);
                    break;
                case 1:
                    list = list.OrderBy(e => e.Price);
                    break;
            }

            foreach (var item in list)
            {
                CollectionToView.Add(item);
            }

            OnPropertyChanged(nameof(CollectionToView));

            _priceId = value;
            OnPropertyChanged(nameof(PriceId));

        }

        public int SelectedId
        {
            get => _selectedId;
            set
            {
                IEnumerable<ProductsBase> list = null;
                CollectionToView.Clear();
                switch (value)
                {
                    case 0:
                        {
                            list = Products;
                            break;
                        }
                    case 1:
                        {
                            list = Products.Where(e => e.Category == "Clothes").ToList();
                            break;
                        }
                    case 2:
                        {
                            list = Products.Where(e => e.Category == "Sport").ToList();
                            break;
                        }
                    case 3:
                        {
                            list = Products.Where(e => e.Category == "Tech").ToList();
                            break;
                        }
                }

                foreach (var item in list)
                {
                    CollectionToView.Add(item);
                }

                OnPropertyChanged(nameof(CollectionToView));

                _selectedId = value;
                OnPropertyChanged(nameof(SelectedId));
                SortByPrice(PriceId);
            }
        }

        public ObservableCollection<ProductsBase> CollectionToView { get; set; } = new();

        private List<ProductsBase> Products { get; }
        public MainViewModel()
        {

            Products = new List<ProductsBase>
            {
                new ProductsBase("Clothes", "Shirt", 15,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Shirt.png"),
                new ProductsBase("Clothes", "Shirt", 10,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Shirt.png"),
                new ProductsBase("Clothes", "Shirt", 1220,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Shirt.png"),
                new ProductsBase("Clothes", "Shirt", 190,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Shirt.png"),
                new ProductsBase("Clothes", "Shirt", 110,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Shirt.png"),
                new ProductsBase("Clothes", "Shirt", 150,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Shirt.png"),

                new ProductsBase("Sport", "Bycycle", 1550,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\bycycle.png"),
                new ProductsBase("Sport", "Bycycle", 10,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\bycycle.png"),
                new ProductsBase("Sport", "Bycycle", 150,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\bycycle.png"),
                new ProductsBase("Sport", "Bycycle", 1190,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\bycycle.png"),
                new ProductsBase("Sport", "Bycycle", 150,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\bycycle.png"),
                new ProductsBase("Sport", "Bycycle", 170,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\bycycle.png"),

                new ProductsBase("Tech", "Phone", 140,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Smartphone.png"),
                new ProductsBase("Tech", "Phone", 10,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Smartphone.png"),
                new ProductsBase("Tech", "Phone", 1500,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Smartphone.png"),
                new ProductsBase("Tech", "Phone", 90,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Smartphone.png"),
                new ProductsBase("Tech", "Phone", 1250,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Smartphone.png"),
                new ProductsBase("Tech", "Phone", 150,  "C:\\Users\\USER\\Desktop\\RealWPF\\RealWPF\\Resources\\Smartphone.png"),


            };

            SelectedId = 0;
        }


    }
}
