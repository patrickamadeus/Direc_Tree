# DirecTree 🎄
Tugas Besar 2 IF2211 Strategi Algoritma Semester II Tahun 2021/2022 
Pemanfaatan Algoritma BFS dan DFS dalam implementasi folder crawling

## Penjelasan Program
Program ini berfungsi untuk melakukan pencarian suatu file dalam suatu root folder. Hasil yang ditampilkan akan berupa Path found dan juga diagram tree yang menunjukkan path pencariannya dan  warna merah dan hijau sebagai penanda ditemukannya file. 

## Algoritma BFS dan DFS
### BFS ( Breadth-First Search )
Breadth-first search merupakan algoritma untuk mencari sebuah simpul dalam sebuah pohon yang mengandung nilai tertentu. BFS melakukan pengecekan pada semua kemungkinan simpul di kedalaman selanjutnya, baru setelah itu melakukan pengecekan untuk kedalaman selanjutnya.

Dalam hal ini, BFS melakukan iterasi untuk mencari file yang sesuai pada semua file yang ada di folder root. Jika belum ketemu, akan melakukan iterasi yang sama pada semua folder di dalam root dan begitu seterusnya.

terdapat dua opsi BFS, yakni pencarian seluruh simpul ataupun pencarian simpul pertama.

### DFS ( Depth-First Search ) 
Depth-first search merupakan algoritma untuk mencari sebuah simpul yang sesuai dalam sebuah pohon yansg mengandung nilai tertentu. DFS melakukan pengecekan pada salah satu cabang. Apabila belum ditemukan simpul sesuai, maka dilakukan rekursi pencarian DFS pada cabang tersebut. Apabila sudah tidak terdapat cabang lagi dan simpul sesuai belum ditemukan, maka dilakukan back-tracking dan melakukan DFS pada cabang yang lain.

Dalam hal ini, DFS melakukan pencarian rekursif dimulai dari root folder yang diberikan user, melakukan iterasi pada semua file yang terdapat pada root folder tersebut. Jika belum ditemukan, maka akan dilakukan pencarian DFS lagi pada salah satu folder dalam root folder tersebut, dan begitu seterusnya.

terdapat dua opsi DFS, yakni pencarian seluruh simpul ataupun pencarian simpul pertama.

## Environment Requirements
* [C#](https://www.microsoft.com/en-us/download/details.aspx?id=7029)
* [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-6.0.3-windows-x64-installer)
* [Visual Studio](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)


## Setup
* Pastikan semua Requirements di atas telah didownload dan diinstall dengan baik
* Lakukan Clone repository pada link github yang dimaksud. 
* Buka aplikasi Visual Studio 
* Klik "open a project or solution" pada menu awal Visual Studio
* Pilih file `Dashboard.sln` yang berlokasi di `Tubes2_13520075/src/Dashboard.sln`
* Klik "start" pada bagian atas menu visual studio
* Ketika Windows Form telah terbuka, klik "Choose.." dan select folder lokasi awal pencarian
* masukkan nama file yang ingin dicari pada kolom "Input file name"
* Pilih BFS/DFS pada pilihan "Choose searching method" sesuai dengan algoritma yang ingin digunakan
* Ceklis pada pilihan "Find All Occurence jika ingin menampilkan semua path yang sesuai
* Biarkan kosong pada pilihan tersebut jika hanya ingin menampilkan path pertama yang ditemukan


## Authors Information
| Nama | NIM | Email | 
| ---- | --- | ----- | 
| Samuel Christopher | 13520075 | 13520075@std.stei.itb.ac.id |
| Patrick Amadeus Irawan | 13520109 | 13520109@std.stei.itb.ac.id |
| Azmi Alfatih Shalahuddin | 13520158 | 13520158@std.stei.itb.ac.id |

## Referensi 
[Munir, Rinaldi, Breadth First Search (BFS) dan Depth First Search (DFS) (Bagian 1) (Versi baru 2021)](https://informatika.stei.itb.ac.id/~rinaldi.munir/Stmik/2020-2021/BFS-DFS-2021-Bag1.pdf.)

[Munir, Rinaldi, Breadth First Search (BFS) dan Depth First Search (DFS) (Bagian 2) (Versi baru 2021)](https://informatika.stei.itb.ac.id/~rinaldi.munir/Stmik/2020-2021/BFS-DFS-2021-Bag2.pdf.)
