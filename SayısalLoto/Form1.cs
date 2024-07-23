using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sayiolustur_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); // Random Prametresi bizae rastgele bir sayı oluştumamız için gerekli olan bir parametredir
            int[] lotteryNumbers = new int[6]; // Burada lotterynumbers adında içine 6 tane sayı alacağını söylüyoruz

            for (int i = 0; i < lotteryNumbers.Length; i++) // burada for dönüsünün içinde oluşan int idfade i lotteryNumbers a yani 6 ya eşit olana kadar for döngüsünün içindeki değerleri döndürmesini istiyoruz
            {
                lotteryNumbers[i] = rand.Next(1, 50); // bu değerler her döndüğünde lotteryNumbers dizisinin içinde 1 ile 50 arasında sayı atıyor taaki 6 kere dönene kadar 
            }

            lbl_Sonuc.Text = string.Join(", ", lotteryNumbers); 
            //string.Join metodu, bir koleksiyon veya dizi içindeki öğeleri belirtilen bir ayraç kullanarak birleştiren bir yöntemdir.
            //Bu metod, bir dizi veya koleksiyon öğelerini birleştirip tek bir string oluşturmak istediğinizde çok kullanışlıdır.
        }
    }
}
