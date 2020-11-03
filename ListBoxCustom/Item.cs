using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxCustom
{
    public class Item
    {
        public int Prix { get; set; }
        public String Titre { get; set; }
        public String Url { get; set; }

        public Item()
        {
        }

        public Item(String titre, int prix, String url)
        {
            this.Titre = titre;
            this.Prix = prix;
            this.Url = url;
        }
    }
}
