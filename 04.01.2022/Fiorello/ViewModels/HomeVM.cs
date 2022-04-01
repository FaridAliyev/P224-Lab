using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<SliderImage> SliderImages { get; set; }
        public SliderText SliderText { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public About About { get; set; }
        public List<AboutFeature> AboutFeatures { get; set; }
        public List<Expert> Experts { get; set; }
    }
}