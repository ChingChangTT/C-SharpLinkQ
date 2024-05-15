using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace showLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int[] A = { 1 , 6 , 20 ,-9 ,0 , 8, 5};
            var vs = from v in A
                     where v>0
                     select v;

            A[0] = 10;
            string str = "";
            foreach (int s in vs) {
                str += s + "\n";
            }
            MessageBox.Show(str);
            */
            
            string[] hname = { "dara.com","bopha.net","nara.org",
                               "mona.com","kaka.net","nora.org",
                               "bona.com","lola.tv"
                             };
            /*
            var vs = from v in hname
                     where v.Substring(v.LastIndexOf('.')).Length>3
                     orderby v descending
                     select v;
            string str = "";
            foreach (string s in vs) {
                str += s + "\n";
            }
            MessageBox.Show(str);
            */
            /*
            product[] pro = { new product("coca",100,7.8),
                              new product("7-up",100,7.5),
                              new product("anchor",100,17.8),
                              new product("tiger",100,22.8)
                            };
            var vs = from vp in pro
                     where vp.price<20
                     orderby vp.pname ascending
                     select new Lproduct(vp.pname,vp.qty);
            string str = "";
            foreach (Lproduct s in vs) {
                str += s.pname + "\t" + s.qty + "\n";
            }
            MessageBox.Show(str); */
            var vs = from v in hname
                     group v by v.Substring(v.LastIndexOf('.')) into nv 
                     select nv;
            string str = "";
            foreach (var s in vs) {
                str += "Group key value is: " + s.Key + "\n";
                foreach (string ss in s) {
                    str += ss + "\n";
                }
            }
            MessageBox.Show(str);
        }
    }
    class Lproduct { 
        public string pname { set; get; }
        public int qty {  set; get; }
        public Lproduct(string pname, int qty)
        {
            this.pname = pname;
            this.qty = qty;
        }
    }
    class product { 
        public string pname { set; get; }
        public int qty { set; get; }
        public double price { set;get; }
        public product(string pname, int qty, double price)
        {
            this.pname = pname;
            this.qty = qty;
            this.price = price;
        }
    }
}
