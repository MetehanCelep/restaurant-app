using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace yazlab3
{
    public partial class Form1 : Form
    {
        private int gelenMusteriSayisi = 0;
        private Button[] masalar;
        private Color[] masaRenkleri;
        private List<string> bekleyenMusteriler = new List<string>();
        private List<string> yerlesenMusteriler = new List<string>();
        private HashSet<string> siparisAlinanMusteriler = new HashSet<string>();
        private object lockObject = new object();
        private Dictionary<string, int> musteriGarsonMap = new Dictionary<string, int>();
        private Queue<int> siparisAlacakAsciQueue = new Queue<int>();
        private Dictionary<int, int> masaAsciMap = new Dictionary<int, int>();
        private Dictionary<int, int> asciSiparisSayisi = new Dictionary<int, int>();
        private int gelenOncelikliMusteriSayisi = 0;
        private Queue<string> oncelikliMusteriQueue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
            masalar = new Button[] { masa1, masa2, masa3, masa4, masa5, masa6 };
            masaRenkleri = new Color[masalar.Length];
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void musterisayitextbox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void EkranDoldur(int musteriSayisi, int oncelikliMusteriSayisi)
        {
            for (int i = 1; i <= oncelikliMusteriSayisi; i++)
            {
                string oncelikliMusteri = "Öncelikli Müşteri " + (i + gelenMusteriSayisi);
                oncelikliMusteriQueue.Enqueue(oncelikliMusteri);
            }

            for (int i = 1; i <= musteriSayisi; i++)
            {
                string musteri = "Müşteri " + (i + gelenMusteriSayisi + gelenOncelikliMusteriSayisi);
                oncelikliMusteriQueue.Enqueue(musteri);
            }

            for (int i = 1; i <= musteriSayisi + oncelikliMusteriSayisi; i++)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    gelenMusteriSayisi++;

                    if (gelenMusteriSayisi <= masalar.Length)
                    {
                        string musteri = oncelikliMusteriQueue.Dequeue();
                        Label label = new Label();
                        label.Text = musteri;
                        yerlesenMusteriler.Add(label.Text);
                        label.Size = new System.Drawing.Size(100, 20);
                        label.Location = new System.Drawing.Point(10, gelenMusteriSayisi * 30);
                        panel1.Controls.Add(label);

                        masalar[gelenMusteriSayisi - 1].BackColor = Color.Red;

                        Label musteriLabel = new Label();
                        musteriLabel.Text = musteri;
                        musteriLabel.Size = new System.Drawing.Size(80, 25);
                        musteriLabel.Location = new System.Drawing.Point(10, 10);
                        masalar[gelenMusteriSayisi - 1].Controls.Add(musteriLabel);

                        int garsonNo = gelenMusteriSayisi % 3 + 1;
                        musteriGarsonMap.Add(musteri, garsonNo);

                        masaAsciMap.Add(gelenMusteriSayisi, gelenMusteriSayisi % 2 + 1);

                        siparisAlacakAsciQueue.Enqueue(gelenMusteriSayisi % 2 + 1);
                    }
                    else
                    {
                        lock (lockObject)
                        {
                            bekleyenMusteriler.Add(oncelikliMusteriQueue.Dequeue());
                            BekleyenMusterileriGoster();
                        }
                    }
                });

                Thread.Sleep(2000);
            }
        }

        private void BekleyenMusterileriGoster()
        {
            this.Invoke((MethodInvoker)delegate
            {
                bekleyenMusteriListbox.Items.Clear();
                bekleyenMusteriListbox.Items.AddRange(bekleyenMusteriler.ToArray());
            });
        }

        private void GarsonCalistir(int garsonNo)
        {
            ListBox garsonListBox = null;

            switch (garsonNo)
            {
                case 1:
                    garsonListBox = Garson1ListBox;
                    break;
                case 2:
                    garsonListBox = Garson2ListBox;
                    break;
                case 3:
                    garsonListBox = Garson3ListBox;
                    break;
            }

            while (true)
            {
                string musteri = GarsonSiparisAl(garsonNo);
                if (musteri == null)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    GarsonSiparisSun(garsonNo, musteri, garsonListBox);
                }
            }
        }

        private string GarsonSiparisAl(int garsonNo)
        {
            lock (lockObject)
            {
                foreach (var kvp in musteriGarsonMap)
                {
                    if (kvp.Value == garsonNo && !siparisAlinanMusteriler.Contains(kvp.Key))
                    {
                        string musteri = kvp.Key;
                        siparisAlinanMusteriler.Add(musteri);
                        return musteri;
                    }
                }
                return null;
            }
        }

        private void GarsonSiparisSun(int garsonNo, string musteri, ListBox garsonListBox)
        {
            this.Invoke((MethodInvoker)delegate
            {
                garsonListBox.Items.Add($"Garson {garsonNo}: {musteri} için sipariş alındı.");
            });
            Thread.Sleep(2000); 
            this.Invoke((MethodInvoker)delegate
            {
                garsonListBox.Items.Add($"Garson {garsonNo}: {musteri} siparişi hazır.");
            });

            lock (lockObject)
            {
                
                bool isOncelikliMusteri = musteri.StartsWith("Öncelikli");

                
                int masaNo = int.Parse(musteri.Split(' ')[isOncelikliMusteri ? 2 : 1]);
                int asciNo = masaAsciMap[masaNo];
                AsciSiparisEkle(asciNo, masaNo);
            }
        }

        private void AsciCalistir(int asciNo)
        {
            ListBox asciListBox = null;

            switch (asciNo)
            {
                case 1:
                    asciListBox = Asci1ListBox;
                    break;
                case 2:
                    asciListBox = Asci2ListBox;
                    break;
            }

            while (true)
            {
                int masaNo = AsciYemekHazirlaAl(asciNo);
                if (masaNo == -1)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    AsciYemekHazirla(asciNo, masaNo, asciListBox);
                }
            }
        }

        private int AsciYemekHazirlaAl(int asciNo)
        {
            lock (lockObject)
            {
                foreach (var kvp in masaAsciMap)
                {
                    int masaNo = kvp.Key;
                    int assignedAsciNo = kvp.Value;

                    if (assignedAsciNo == asciNo && siparisAlacakAsciQueue.Contains(masaNo))
                    {
                        siparisAlacakAsciQueue.Dequeue(); 
                        return masaNo;
                    }
                }
                return -1;
            }
        }

        private void AsciYemekHazirla(int asciNo, int masaNo, ListBox asciListBox)
        {
            this.Invoke((MethodInvoker)delegate
            {
                asciListBox.Items.Add($"Aşçı {asciNo}: Masa {masaNo} için yemek hazırlanıyor.");
            });

            Thread.Sleep(3000); 

            this.Invoke((MethodInvoker)delegate
            {
                asciListBox.Items.Add($"Aşçı {asciNo}: Masa {masaNo} için yemek hazır.");
            });

            lock (lockObject)
            {
                if (masaAsciMap.ContainsKey(masaNo))
                {
                    siparisAlacakAsciQueue.Enqueue(masaNo);
                }
                else
                {
                    Console.WriteLine($"Hata: Masa {masaNo} için aşçı atanmamış.");
                }
            }

            HesapOde(masaNo);
        }
        private void AsciSiparisEkle(int asciNo, int masaNo)
        {
            lock (lockObject)
            {
                if (asciSiparisSayisi.ContainsKey(asciNo))
                {
                    asciSiparisSayisi[asciNo]++;
                }
                else
                {
                    asciSiparisSayisi.Add(asciNo, 1);
                }

                if (masaAsciMap.ContainsKey(masaNo))
                {
                    int assignedAsciNo = masaAsciMap[masaNo];

                    if (asciNo == assignedAsciNo)
                    {
                        
                        siparisAlacakAsciQueue.Enqueue(masaNo);
                    }
                    else
                    {
                    
                        Console.WriteLine($"Hata: Masa {masaNo} için doğru aşçı atanmamış.");
                    }
                }
                else
                {
                
                    Console.WriteLine($"Hata: Masa {masaNo} için aşçı atanmamış.");
                }
            }
        }

        private void HesapOde(int masaNo)
        {
            string musteriAdi = "Masa " + masaNo;
            Thread.Sleep(3000);

            this.Invoke((MethodInvoker)delegate
            {
            KasaListBox.Items.Add($"{musteriAdi} hesabını ödedi.");
            masalar[masaNo - 1].BackColor = Color.Lime;
            masalar[masaNo - 1].Controls.Clear();
            yerlesenMusteriler.Remove(musteriAdi);
            siparisAlinanMusteriler.Remove(musteriAdi);
            musteriGarsonMap.Remove(musteriAdi);
            masaAsciMap.Remove(masaNo);
            asciSiparisSayisi.Remove(masaNo);

            while (bekleyenMusteriler.Count > 0)
            {
                string bekleyenMusteri = bekleyenMusteriler[0];
                int bosMasaIndex = Array.FindIndex(masalar, masa => masa.BackColor == Color.Lime);

                if (bosMasaIndex != -1)
                {
                    bekleyenMusteriler.RemoveAt(0);

                    masalar[bosMasaIndex].BackColor = Color.Red;

                    Label musteriLabel = new Label();
                    musteriLabel.Text = bekleyenMusteri;
                    musteriLabel.Size = new System.Drawing.Size(80, 25);
                    musteriLabel.Location = new System.Drawing.Point(10, 10);
                    masalar[bosMasaIndex].Controls.Add(musteriLabel);

                    int garsonNo = bosMasaIndex % 3 + 1;
                    musteriGarsonMap.Add(bekleyenMusteri, garsonNo);

                    masaAsciMap.Add(bosMasaIndex + 1, (bosMasaIndex + 1) % 2 + 1);
                        siparisAlacakAsciQueue.Enqueue((bosMasaIndex + 1) % 2 + 1);
                    }
                    else
                    {
                        break;
                    }
                }

                BekleyenMusterileriGoster();
            });
        }


        private void Garson1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Garson2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Garson3ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Asci1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Asci2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            
        }

        private void masa2_Click(object sender, EventArgs e)
        {
           
        }

        private void masa3_Click(object sender, EventArgs e)
        {

        }

        private void masa4_Click(object sender, EventArgs e)
        {
           
        }

        private void masa5_Click(object sender, EventArgs e)
        {
           
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void OnaylaButton_Click(object sender, EventArgs e)
        {
            int musteriSayisi;
            if (!int.TryParse(musterisayitextbox.Text, out musteriSayisi) || musteriSayisi < 1 || musteriSayisi > 10)
            {
                MessageBox.Show("Geçerli bir müşteri sayısı giriniz (1-10 arasında).");
                return;
            }

            int oncelikliMusteriSayisi;
            if (!int.TryParse(textBoxOncelikli.Text, out oncelikliMusteriSayisi) || oncelikliMusteriSayisi < 0)
            {
                MessageBox.Show("Geçerli bir öncelikli müşteri sayısı giriniz (0 ve üzeri).");
                return;
            }

            Thread thread = new Thread(() => EkranDoldur(musteriSayisi, oncelikliMusteriSayisi));
            thread.Start();

            new Thread(() => GarsonCalistir(1)).Start();
            new Thread(() => GarsonCalistir(2)).Start();
            new Thread(() => GarsonCalistir(3)).Start();
            new Thread(() => AsciCalistir(1)).Start();
            new Thread(() => AsciCalistir(2)).Start();
        }

        private void KasaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxOncelikli_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
