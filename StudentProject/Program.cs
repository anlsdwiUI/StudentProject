using StudentProject;
using System;

void Display()
{
    Console.Clear();
    Console.WriteLine("Selamat Datang Di Toko Kami");
    Console.WriteLine("1. Tambah Produk");
    Console.WriteLine("2. Edit Produk");
    Console.WriteLine("3. Tampilan Produk");
    Console.WriteLine("4. Hapus Produk");
    Console.WriteLine("5. Add Produk ke Cart");
    Console.WriteLine("6. Hapus Produk dari Cart");
    Console.WriteLine("7. Tampilkan Cart");
    Console.WriteLine("8. Checkout");
    Console.WriteLine("9. Keluar");
}
var keluar = false;
var product = new List<Product>();
var cart = new List<Cart>();


while (!keluar)
{
    Display();
    string pilihan = Console.ReadLine();
    switch (pilihan)
    {
        case "1":
            Console.WriteLine("Tambah Produk");
            Console.WriteLine("Masukkan SKU : ");
            string sku = Console.ReadLine();

            if (product.Any(prod => prod.Sku == sku))
            {
                Console.WriteLine("Kode produk {0} sudah ada", sku);
                Console.ReadLine();
                break;
            }
            Console.WriteLine("Masukkan Nama Produk: ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan Harga: ");
            double harga = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Stok: ");
            int stock = int.Parse(Console.ReadLine());

            Product newProduct = new Product(sku, nama, stock, harga);
            product.Add(newProduct);

            // menampilkan list product
            Console.WriteLine("\t\tList Produk");
            Console.WriteLine("------------------------------------");
            // Membuat header tabel
            Console.WriteLine("SKU\tNama\tHarga\tStok");
            Console.WriteLine("------------------------------------");

            // Loop melalui setiap objek Product
            foreach (Product prod in product)
            {
                // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                Console.WriteLine($"{prod.Sku}\t{prod.Nama}\t{prod.Harga}\t{prod.Stock}");
            }

            // Mencetak garis bawah untuk menandakan akhir dari tabel
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
            break;

            case "2":
                Console.WriteLine("\t\tList Produk");
                Console.WriteLine("------------------------------------");
                // Membuat header tabel
                Console.WriteLine("No\tSKU\tNama\tHarga\tStok");
                Console.WriteLine("------------------------------------");

                // Loop melalui setiap objek Product
                foreach (Product prod in product)
                {
                    // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                    Console.WriteLine($"\t{prod.Sku}\t{prod.Nama}\t{prod.Harga}\t{prod.Stock}");
                }

                // Mencetak garis bawah untuk menandakan akhir dari tabel
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Edit Produk");
                Console.WriteLine("Masukan SKU: ");
                string editSku  = Console.ReadLine();

                Product editProduk = product.Find(pEdit => pEdit.Sku == editSku);

                if(editProduk != null)
                {
                    Console.WriteLine("Masukan Nama Produk Baru: ");
                    string newNama = Console.ReadLine();
                    Console.WriteLine("Masukkan Stok Baru: ");
                    string newStok = Console.ReadLine();
                    Console.WriteLine("Masukkan Harga Baru: ");
                    double newHarga = double.Parse(Console.ReadLine());
                    Console.WriteLine("Masukkan Stok Baru: ");
                    int newStock = int.Parse(Console.ReadLine());
                    Console.WriteLine("Produk berhasil di edit");

                    Console.WriteLine("Data Produk Berhasil diubah");
                    Console.WriteLine("\t\tList Produk");
                    Console.WriteLine("------------------------------------");
                    // Membuat header tabel
                    Console.WriteLine("SKU\tNama\tHarga\tStok");
                    Console.WriteLine("------------------------------------");

                    // Loop melalui setiap objek Product
                    foreach (Product prod in product)
                    {
                        // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                        Console.WriteLine($"{prod.Sku}\t{prod.Nama}\t{prod.Harga}\t{prod.Stock}");
                    }

                    // Mencetak garis bawah untuk menandakan akhir dari tabel
                    Console.WriteLine("------------------------------------");
                }
                else
                {
                    Console.WriteLine("Sku yang dimasukan tidak ada");
                }
                Console.ReadLine ();
                break;

            case "3":
                if (product.Count > 0)
                {
                    Console.WriteLine("\t\tList Produk");
                    Console.WriteLine("------------------------------------");
                    // Membuat header tabel
                    Console.WriteLine("SKU\tNama\tHarga\tStok");
                    Console.WriteLine("------------------------------------");

                    // Loop melalui setiap objek Product
                    foreach (Product prod in product)
                    {
                        // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                        Console.WriteLine($"{prod.Sku}\t{prod.Nama}\t{prod.Harga}\t{prod.Stock}");
                      
                    }

                    // Mencetak garis bawah untuk menandakan akhir dari tabel
                    Console.WriteLine("------------------------------------");
            }
                else
                {
                    Console.WriteLine("Daftar Produk Masih Kosong");
                }
                Console.ReadLine ();
            break;
            case "4":
                Console.WriteLine("\t\tList Produk");
                Console.WriteLine("------------------------------------");
                // Membuat header tabel
                Console.WriteLine("SKU\tNama\tHarga\tStok");
                Console.WriteLine("------------------------------------");

                // Loop melalui setiap objek Product
                foreach (Product prod in product)
                {
                    // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                    Console.WriteLine($"{prod.Sku}\t{prod.Nama}\t{prod.Harga}\t{prod.Stock}");
                }

                // Mencetak garis bawah untuk menandakan akhir dari tabel
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Hapus Produk");
                Console.WriteLine("Masukkan SKU: ");
                string delSku = Console.ReadLine ();
                var delProduk = product.Find(hapusProduk => hapusProduk.Sku == delSku);
            
                if (delProduk != null)
                {
                    product.Remove(delProduk);
                    Console.WriteLine("Produk dengan kode {0} berhasil di hapus", delProduk);
                }
                else 
                {
                    Console.WriteLine("Produk dengan kode {0} tidak ditemukan", delSku);
                }
                Console.ReadLine();
                break;

            case "5":
                Console.WriteLine("\t\tList Produk");
                Console.WriteLine("------------------------------------");
                // Membuat header tabel
                Console.WriteLine("SKU\tNama\tHarga\tStok");
                Console.WriteLine("------------------------------------");

                // Loop melalui setiap objek Product
                foreach (Product prod in product)
                {
                    // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                    Console.WriteLine($"{prod.Sku}\t{prod.Nama}\t{prod.Harga}\t{prod.Stock}");
                }

                // Mencetak garis bawah untuk menandakan akhir dari tabel
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Masukan SKU yang ingin ditambahkan ke dalam cart: ");
                string skuCart = Console.ReadLine ();
            
                Product produkCart = product.FirstOrDefault(p => p.Sku == skuCart);

                if(produkCart != null)
                {
                    Console.WriteLine("Masukkan jumlah produk yang ingin ditambahkan ke dalam cart: ");
                    int quantity = int.Parse(Console.ReadLine());

                    Cart carts = new Cart(produkCart, quantity);
                    cart.Add(carts);
                    produkCart.Stock -= quantity;

                    Console.WriteLine("Produk berhasil ditambahkan ke dalam cart");
                }
                else
                {
                    Console.WriteLine("Produk dengan SKU {0} tidak ditemukan.", skuCart);
                }
                    Console.WriteLine();
                    Console.WriteLine("\t\tList Keranjang");
                    Console.WriteLine("------------------------------------");
                    // Membuat header tabel
                    Console.WriteLine("SKU\tNama\tHarga\tJumlah");
                    Console.WriteLine("------------------------------------");

                // Loop melalui setiap objek Product
                foreach (var item in cart)
                {
                    // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                    Console.WriteLine($"{item.Product.Sku}\t{item.Product.Nama}\t{item.Product.Harga}\t{item.Quantity}");
                }

                // Mencetak garis bawah untuk menandakan akhir dari tabel
                Console.WriteLine("------------------------------------");
                Console.ReadLine();
                break;

            case "6":
                Console.WriteLine("\t\tList Keranjang");
                Console.WriteLine("------------------------------------");
                // Membuat header tabel
                Console.WriteLine("SKU\tNama\tHarga\tJumlah");
                Console.WriteLine("------------------------------------");

                // Loop melalui setiap objek Product
                foreach (var item in cart)
                {
                    // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                    Console.WriteLine($"{item.Product.Sku}\t{item.Product.Nama}\t{item.Product.Harga}\t{item.Quantity}");
                }

                // Mencetak garis bawah untuk menandakan akhir dari tabel
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Masukkan SKU produk yang ingin dihapus dari cart: ");
                string removeSku = Console.ReadLine ();
                Console.WriteLine("Masukkan jumlah produk yang ingin dihapus dari cart: ");
                int removeQyt = int.Parse(Console.ReadLine());
                Cart removeCart = cart.FirstOrDefault(c => c.Product.Sku == removeSku);

                if (removeCart != null)
                {
                    if (removeCart.Quantity >= removeQyt)
                    {
                        removeCart.Quantity -= removeQyt;
                        removeCart.Product.Stock += removeQyt;
                        Console.WriteLine("Berhasil menghapus produk dengan SKU dari cart");
                    }
                    else
                    {
                        Console.WriteLine("Jumlah produk dengan SKU dalam cart tidak mencukupi");
                    }
                }
                else
                {
                    Console.WriteLine("Produk dengan SKU tersebut tidak ditemukan di dalam cart");
                }
                Console.ReadLine ();
                break;

            case "7":
                if (cart.Count > 0)
                {
                        Console.WriteLine("\t\tList Keranjang");
                        Console.WriteLine("------------------------------------");
                        // Membuat header tabel
                        Console.WriteLine("SKU\tNama\tHarga\tJumlah");
                        Console.WriteLine("------------------------------------");

                        // Loop melalui setiap objek Product
                        foreach (var item in cart)
                        {
                            // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                            Console.WriteLine($"{item.Product.Sku}\t{item.Product.Nama}\t{item.Product.Harga}\t{item.Quantity}");
                        }

                        // Mencetak garis bawah untuk menandakan akhir dari tabel
                        Console.WriteLine("------------------------------------");
                }
                else
                {
                    Console.WriteLine("Chart masih kosong");
                }
                Console.ReadLine ();
                break;

        case "8":
            if (cart.Count > 0)
            {
                double total = 0;
                Console.WriteLine("\t\tList Keranjang");
                Console.WriteLine("------------------------------------");
                // Membuat header tabel
                Console.WriteLine("SKU\tNama\tHarga\tJumlah");
                Console.WriteLine("------------------------------------");
                // Loop melalui setiap objek Cart
                foreach (var item in cart)
                {
                    // Mencetak nilai dari setiap kolom dengan tab sebagai separator
                    Console.WriteLine($"{item.Product.Sku}\t{item.Product.Nama}\t{item.Product.Harga}\t{item.Quantity}");
                    total += item.Product.Harga * item.Quantity;
                }
                // Mencetak garis bawah untuk menandakan akhir dari tabel
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Total: {0}", total);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Bayar");
                Console.WriteLine("2. Cancel");

                string cekoutOption = Console.ReadLine();
                if (cekoutOption == "1")
                {
                    // Kurangi stock produk dan hapus keranjang belanja
                    foreach (var item in cart)
                    {
                        item.Product.Stock -= item.Quantity;
                    }
                    cart.Clear();
                    Console.WriteLine("Pembayaran Berhasil");
                }
                else if (cekoutOption == "2")
                {
                    Console.WriteLine("Pembayaran dibatalkan");
                }
                else
                {
                    Console.WriteLine("Input tidak valid");
                }
            }
            else
            {
                Console.WriteLine("Keranjang belanja kosong");
            }
            Console.ReadLine();
            break;


        case "9":
                Console.WriteLine("Keluar");
                keluar = true;
                break;
        default:
            Console.WriteLine("Pilihan Tidak Ada");
            break;
    }
}

