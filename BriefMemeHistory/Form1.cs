using System;
using System.Windows.Forms;

namespace myMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            //webBrowser1.Url = new System.Uri("https://google.com", System.UriKind.Absolute);
            webBrowser1.Url = new Uri("https://hamster.dance/hamsterdance/", UriKind.Absolute);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.allyourbasearebelongtous.com/gif/", UriKind.Absolute);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/NL6CDFn2i3I?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //webBrowser1.Url = new System.Uri("https://www.allyourbasearebelongtous.com/gif/", System.UriKind.Absolute);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/tP6w22ToHgc?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://hamster.dance/hamsterdance/", UriKind.Absolute);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //webBrowser1.Url = new System.Uri("https://pebbz.hubs.vidyard.com/watch/tpI4XCeKTyvDGreKI7_EbA", System.UriKind.Absolute);
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/fZu3P0OsQPk?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //webBrowser1.Url = new System.Uri("https://i.pinimg.com/originals/16/1a/78/161a78947b9f09d4f34de18201b94e76.png", System.UriKind.Absolute);
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/mLyOj_QD4a4?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(
                "https://www.researchgate.net/profile/Kenneth-Mick-Evans/publication/334052666/figure/fig3/AS:774384759341057@1561639122164/Example-of-an-Advice-Dog-image-macro-the-meme-which-spawned-a-larger-category-of-meme.png",
                UriKind.Absolute);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //webBrowser1.Url = new System.Uri("https://i.kym-cdn.com/entries/icons/facebook/000/000/056/itsover1000.jpg", System.UriKind.Absolute);
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/PCHxU7witPA?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/EwTZ2xpQwpA?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/J---aiyznGQ?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/_3wkyerSBpw?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://i.pinimg.com/originals/58/0b/59/580b594290a355948123706c38f73aa4.png",
                UriKind.Absolute);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://i.kym-cdn.com/photos/images/newsfeed/001/894/370/550.png",
                UriKind.Absolute);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/MtN1YnoL46Q?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/MX0D4oZwCsA?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            //https://i.insider.com/5d39f6aba13c955d0b76fa94?width=600&format=jpeg&auto=webp
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/kfVsfOSbJY0?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void Form1_Load_3(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/QH2-TGUlwu4?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void Form1_Load_4(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/my1uUdquG_4?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://blog.hitbtc.com/wp-content/uploads/2016/03/doge.jpg", UriKind.Absolute);
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://i.insider.com/5d39f6aba13c955d0b76fa94?width=600&format=jpeg&auto=webp",
                UriKind.Absolute);
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/5Ec8zMxPVzk?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/Fkk9DI-8el4?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://i.kym-cdn.com/entries/icons/original/000/027/937/cover.jpg",
                UriKind.Absolute);
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/PfYnvDL0Qcw?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"1015\" height=\"481\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/X0YLt4dcx8w?autoplay=1";
            webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}