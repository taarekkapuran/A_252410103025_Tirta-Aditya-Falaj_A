// Nama : Tirta Aditya Falaj
// NIM : 252410103025
// Pemrograman Berorientasi Obyek kelas A ( C# )

// Studi Kasus //

// Pemerintah sedang menjalankan program Makan Bergizi Gratis (MBG) untuk -
// menyediakan makanan sehat dan bergizi bagi siswa di berbagai sekolah. Agar program ini -
// berjalan dengan lancar, setiap dapur MBG bertanggung jawab menyiapkan makanan, -
// mengelola persediaan bahan makanan, serta mendistribusikan paket makanan kepada sekolah -
// penerima. Namun, seiring bertambahnya jumlah sekolah yang dilayani, pengelolaan distribusi -
// MBG menjadi semakin kompleks. Beberapa sekolah mengalami keterlambatan pengiriman, -
// sementara dapur pusat harus memastikan jumlah paket makanan yang dikirim tidak melebihi -
// stok yang tersedia.

// Sebagai seorang Software Developer yang ditugaskan untuk mengembangkan sistem -
// MBG, tugasmu adalah merancang aplikasi sistem manajemen berbasis objek menggunakan -
// C# untuk mengelola data sekolah penerima, jenis paket makanan, perhitungan biaya, serta -
// proses distribusi makanan.

// Soal //

// Soal 1 : Buatlah class Sekolah yang merepresentasikan sekolah penerima program MBG. -
// Atribut yang harus dimiliki:

// - idSekolah (string)
// - namaSekolah (string)
// - jumlahPaketDiterima (int)

// Tambahkan method TampilInfo() untuk menampilkan informasi sekolah, meliputi ID -
// sekolah, nama sekolah, dan jumlah paket makanan yang telah diterima. Buat minimal -
// dua objek Sekolah dengan data yang berbeda di dalam fungsi Main().

// Soal 2 : Buatlah class PaketMBG (yang nantinya menjadi basis produk makanan) dengan -
// atribut bersifat private: 

// - idPaket (string)
// - namaPaket (string)
// - stokDapur (int)

// Sediakan properties atau getter & setter untuk mengakses atribut tersebut. 

// Tetapkan aturan berikut: 

//    1. Nilai stokDapur tidak boleh bernilai negatif,
//    2. Stok dapur tidak boleh dikurangi secara langsung dari luar class, 
//    3. Pengurangan stok hanya boleh dilakukan melalui method khusus KurangiStok(int jumlah), 
//    4. Method KurangiStok() harus memastikan jumlah pengurangan valid dan tidak melebihi stok yang tersedia. 

// Soal 3 : Buatlah dua class turunan dari PaketMBG, yaitu: 

//    a. PaketReguler : Paket makanan bergizi dengan harga Rp15.000 per paket. Paket ini berisi nasi, ayam, sayur, dan buah. 
//    b. PaketKhusus  : Paket makanan dengan harga Rp20.000 per paket. Paket ini disediakan bagi siswa yang memiliki kebutuhan -
//                      makanan khusus. Paket ini memiliki atribut tambahan jenisDiet (string), misalnya "Rendah Gula","Vegetarian", -
//                      atau "Bebas Gluten".

// Gunakan konsep inheritance (pewarisan) agar kedua class turunan ini mewarisi seluruh atribut dan method dari PaketMBG.

// Jawab : 

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Tampilkan Informasi Sekolah Penerima MBG");

        Console.WriteLine("===============================================");

        Console.WriteLine("ID Sekolah            : A1.1");
        Console.WriteLine("Nama Sekolah          : SD Negeri Jombang 3");
        Console.WriteLine("Jumlah Paket Diterima : 200");

        Console.WriteLine("===============================================");

        Console.WriteLine("ID Sekolah            : A1.2");
        Console.WriteLine("Nama Sekolah          : SMP Negeri Karetan 12");
        Console.WriteLine("Jumlah Paket Diterima : 650");

        Console.WriteLine("===============================================");

        Console.WriteLine("ID Sekolah            : A1.3");
        Console.WriteLine("Nama Sekolah          : SMA Negeri Ngawi 1");
        Console.WriteLine("Jumlah Paket Diterima : 1500");

        Console.WriteLine(" ");

        Console.WriteLine("2. Paket MBG");

        Console.WriteLine("===============================================");

        Console.WriteLine("ID Paket   : A12");
        Console.WriteLine("Nama Paket : LRAMS");
        Console.WriteLine("Stok Dapur : 1000");

        Console.WriteLine("===============================================");

        Console.WriteLine("ID Paket   : A22");
        Console.WriteLine("Nama Paket : SRBLH");
        Console.WriteLine("Stok Dapur : 1400");

        Console.WriteLine("===============================================");

        Console.WriteLine("ID Paket   : A32");
        Console.WriteLine("Nama Paket : GSHARK");
        Console.WriteLine("Stok Dapur : 1600");

        Console.WriteLine(" ");

        Console.WriteLine("3. Jenis Paket MBG");

        Console.WriteLine("===============================================");

        Console.WriteLine("Jenis Paket       : Paket Reguler");
        Console.WriteLine("Rincian Harga     : RP. 15.000 / Paket");
        Console.WriteLine("Isi Paket         : Nasi, ayam, sayur, dan buah");
        Console.WriteLine("Stok Dapur LRAMS  : 800");
        Console.WriteLine("Stok Dapur SRBLH  : 1000");
        Console.WriteLine("Stok Dapur GSHARK : 1300");

        Console.WriteLine("===============================================");

        Console.WriteLine("Jenis Paket       : Paket Khusus");
        Console.WriteLine("Isi Paket         : Nasi, ayam, sayur, dan buah");
        Console.WriteLine("Rincian Paket     : Rendah gula, vegetarian, bebas gluten");
        Console.WriteLine("Rincian Harga     : RP. 20.000 / Paket");
        Console.WriteLine("Stok Dapur LRAMS  : 200");
        Console.WriteLine("Stok Dapur SRBLH  : 400");
        Console.WriteLine("Stok Dapur GSHARK : 300");
    }
}