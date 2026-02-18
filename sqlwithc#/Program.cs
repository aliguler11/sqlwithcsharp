using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlwithc_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region urun kategorılerını sıralıyor
            //SqlConnection connection = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable datatable = new DataTable();
            //adapter.Fill(datatable);
            //foreach (DataRow row in datatable.Rows)
            //{

            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }

            //}
            #endregion

            #region kategorileri ekleme 
            //SqlConnection connection2 = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection2.Open();


            //Console.WriteLine("eklemek istediginiz kategori: ");
            //string yenikategori = Console.ReadLine();
            //SqlCommand komut = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //komut.Parameters.AddWithValue("@p1", yenikategori);
            //komut.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("eklendi");

            #endregion

            #region ürün ekleme

            //string ürünad;
            //decimal ürünfiyat;
            //Console.Write("ürün adı: ");
            //ürünad = Console.ReadLine();
            //Console.Write("ürün fiyat: ");
            //ürünfiyat = decimal.Parse(Console.ReadLine());
            //SqlConnection connection3 = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection3.Open();
            //SqlCommand komut3 = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@ürünad,@ürünfiyat,@bool)", connection3);
            //komut3.Parameters.AddWithValue("@ürünad", ürünad);
            //komut3.Parameters.AddWithValue("@ürünfiyat", ürünfiyat);
            //komut3.Parameters.AddWithValue("@bool", true);
            //komut3.ExecuteNonQuery();
            //connection3.Close();
            //Console.WriteLine("urun eklendi");











            #endregion

            #region ürün listeleme

            //SqlConnection connection4 = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection4.Open();
            //SqlCommand komut4 = new SqlCommand("select * from TblProduct",connection4);
            //SqlDataAdapter adapter4 = new SqlDataAdapter(komut4);
            //DataTable dt4 = new DataTable();
            //adapter4.Fill(dt4);

            //foreach (DataRow row in dt4.Rows)
            //{
            //    // Döngü içinde her hücreyi geziyoruz
            //    for (int i = 0; i < row.ItemArray.Length; i++)
            //    {
            //        // Eğer baktığımız hücre 3. indeksteki (yani True/False olan) hücre DEĞİLSE yazdır
            //        if (i != 3)
            //        {
            //            Console.Write(row.ItemArray[i].ToString() + " ");
            //        }
            //    }

            //    // Satırın sonunda kontrolü yapıp özel mesajımızı yazıyoruz ✍️
            //    if (row.ItemArray[3].ToString() == "True")
            //    {
            //        Console.Write(" -> Ürün Mevcut ");
            //    }
            //    else
            //    {
            //        Console.Write(" -> Ürün Stokta Yok ");
            //    }

            //    Console.WriteLine(); // Yeni satıra geç
            //}
            //connection4.Close();
            #endregion

            #region ürün silme

            //int productid;
            //Console.WriteLine("silinecek ürün kodunu giriniz: ");
            //productid=int.Parse(Console.ReadLine());
            //SqlConnection connection5 = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection5.Open();
            //SqlCommand komut5 = new SqlCommand("Delete From TblProduct where ProductId=@productid  ",connection5);
            //komut5.Parameters.AddWithValue("@productid",productid );
            //komut5.ExecuteNonQuery();
            //connection5.Close();
            //Console.WriteLine("silindi.");

            #endregion

            #region ürün güncelleme

            //int id,newprice;
            //Console.WriteLine("güncellenecek ürün kodunu giriniz: ");
            //id = int.Parse(Console.ReadLine());
            //Console.WriteLine("ürünün yeni fiyatını giriniz: ");
            //newprice = int.Parse(Console.ReadLine());

            //SqlConnection connection6 = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection6.Open();
            //SqlCommand komut6 = new SqlCommand("Update TblProduct Set  ProductPrice=@newprice where ProductId=@id ", connection6);
            //komut6.Parameters.AddWithValue("@newprice", newprice);
            //komut6.Parameters.AddWithValue("@id", id);
            //komut6.ExecuteNonQuery();
            //connection6.Close();
            //Console.WriteLine("Urun fıyatı basarıyla guncellendi.");

            #endregion

            #region kategori silme

            //int kategoriid;
            //Console.WriteLine("silinecek kategorinin ID'sini giriniz: ");
            //kategoriid = int.Parse(Console.ReadLine());
            //SqlConnection connection7 = new SqlConnection("Data Source=localhost; initial Catalog=EgitimKampiDb; integrated security=true");
            //connection7.Open();
            //SqlCommand komut7 = new SqlCommand("Delete From TblCategory where CategoryId=@kategoriid  ", connection7);
            //komut7.Parameters.AddWithValue("@kategoriid", kategoriid);
            //komut7.ExecuteNonQuery();
            //connection7.Close();
            //Console.WriteLine("kategori silindi.");

            #endregion


        }
    }
}
