using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.IO;

class main { static void Main() { Application.Run(new start()); } }


class Karta
{
    public bool kozur = false;
    public PictureBox img = new PictureBox();
    public int vaga = 0;
    public bool vkolode = true;
    public int mast;
    public bool vigre = false;
    public PictureBox face = new PictureBox();
    public  Karta(){
    face.Image = new Bitmap(start.adrec+"\\img\\face.jpg");
    face.Width = 71;
    face.Height = 96;


    
    }
}


class start : Form
{
    Karta[] koloda = new Karta[36];
    
    RadioButton[] leng = new RadioButton[2];

    public static string adrec = @Application.StartupPath;
    int kozur;

    CheckBox hp = new CheckBox();
    RichTextBox help = new RichTextBox();

    int my_num = 99;
    int he_naum = 99;
    int col_kart;
    int col_vigre = 0;
    int makx = 0;

    bool nacrt = false;
    bool can_go1 = false;
    bool vidbuv = false;
    bool can_go = false;
    bool can_go2 = false;
    bool ed = false;
    bool end = false;

    string[] helper = new string[4];


    string[] info = new string[3];

    List<int> my_kart_only = new List<int>();
    PictureBox face = new PictureBox();
    PictureBox mast = new PictureBox();
    List<int> moe = new List<int>();
    List<Karta> moi_kartu= new List<Karta>();
    List<Karta> voroga_kartu = new List<Karta>();
    List<Karta> ctil_kartu = new List<Karta>();

    TableLayoutPanel ctol = new TableLayoutPanel();

    FlowLayoutPanel her = new FlowLayoutPanel();
    FlowLayoutPanel my = new FlowLayoutPanel();
    
    FlowLayoutPanel f = new FlowLayoutPanel();
    FlowLayoutPanel s = new FlowLayoutPanel();


    FileInfo iff = new FileInfo(adrec + "\\setting.txt");

    string h = "";
    string m = "";
    int left_center;
    int top_center;

    PictureBox go_end = new PictureBox();
    PictureBox up = new PictureBox();
    Label col = new Label();



    public start()
    {
        this.Font = new Font("Comic Sans MS", 8f, FontStyle.Regular);
        

        go_end.Width = 50;
        go_end.Height = 60;
        go_end.Image = new Bitmap(adrec+"\\img\\go_menu.jpg");
        go_end.Left = SystemInformation.PrimaryMonitorSize.Width - 50;
        go_end.BorderStyle = BorderStyle.FixedSingle;
        go_end.MouseClick += new MouseEventHandler(go_end_MouseClick);

        helper[0] = "Enter (ентер) : супротивник починає бити ваші карти.\r\n";
        helper[1] = "Space (пробіл) : закінчити хід, більше не пікидаю.\r\n";
        helper[3] = "Space (пробіл) : беру карти, не можу відбити.\r\n";
        helper[2] = "Enter (ентер) : відбив карти супротивника, очистити стіл якщо противник не підкине.\r\n";



        
        left_center = SystemInformation.PrimaryMonitorSize.Width / 2;
        top_center = SystemInformation.PrimaryMonitorSize.Height / 2;

        her.Top = 30;
        her.Width = SystemInformation.PrimaryMonitorSize.Width - ((left_center / 3) * 2); ;
        her.BackgroundImage = new Bitmap(adrec + "\\img\\game2.jpg");
        her.Height = 116;
        her.Left = left_center / 3;
        her.AutoScroll = true;

        ctol.Top = top_center - 100;
        ctol.BackgroundImage = new Bitmap(adrec+"\\img\\game2.jpg");
        ctol.Left = left_center/3;
        ctol.RowCount = 2;
        ctol.Width = SystemInformation.PrimaryMonitorSize.Width - ((left_center / 3) * 2);
        ctol.Height = 300;

        
        my.AutoScroll = true;
        my.BackgroundImage = new Bitmap(adrec + "\\img\\game2.jpg");
        my.Top = SystemInformation.PrimaryMonitorSize.Height-166;
        my.Width = SystemInformation.PrimaryMonitorSize.Width-((left_center / 3)*2);
        my.Height = SystemInformation.PrimaryMonitorSize.Height - my.Top-30;
        my.FlowDirection = FlowDirection.LeftToRight;
        my.Left = left_center / 3;
        

        help.Enabled  = false;
        help.Left = my.Width + my.Left + 20;
        help.Top = SystemInformation.PrimaryMonitorSize.Height - 130;
        help.Height = 130;
        help.Multiline = true;
        help.Width = SystemInformation.PrimaryMonitorSize.Width - help.Left;


        face.Image = new Bitmap(adrec + "\\img\\face.jpg");
        face.Width = 71;
        face.Height = 96;
        face.Top = top_center - (face.Height / 2);
        face.Left = (SystemInformation.PrimaryMonitorSize.Width / 100) * 3;



        up.Text = "Ворог взяв карти.";
        up.Width = 200;
        up.Height = 50;
        up.Left = left_center-(up.Width/2);
        up.Top = top_center - (up.Height/2);
        up.Image = new Bitmap(adrec+"\\img\\up.jpg");
        

        mast.Width = 30;
        mast.Height = 30;
        mast.Top = top_center - ((face.Height / 2)-10);
        mast.Left = face.Left+(face.Width/3);
        mast.BorderStyle = BorderStyle.None;

        col.Left = mast.Left;
        col.Top = mast.Top + mast.Height + 20;
        col.BackColor = Color.White;
        col.Width = 30;
        col.TextAlign = ContentAlignment.MiddleCenter;
        col.ForeColor = Color.Black;

        this.Icon = new Icon(adrec+"\\ico.ico");
        this.KeyUp += new KeyEventHandler(enter_cick);
        this.KeyUp += new KeyEventHandler(start_KeyUp);




        this.Width = SystemInformation.PrimaryMonitorSize.Width;
        this.Height = SystemInformation.PrimaryMonitorSize.Height;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.None;
        this.Text = "ДУРАК.";
        this.MouseWheel += new MouseEventHandler(up_dow);


        menu();
    }





    public void menu()
    {
        Bitmap b = new Bitmap(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
        Graphics zz;
        zz = Graphics.FromImage(b);
        zz.DrawImage(new Bitmap(adrec + "\\img\\back.gif"), 0, 0, SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);


        this.BackgroundImage = b;
        this.BackgroundImageLayout = ImageLayout.Stretch;


        if (iff.Exists == false)
        {
            StreamWriter txt_st = iff.CreateText();

            txt_st.WriteLine("Language: ua ;");
            txt_st.WriteLine("Type of card: 1 ;");
            txt_st.WriteLine("Help: true ;");
            txt_st.Close();

        }


        int mas = 0;

        StreamReader txt = iff.OpenText();

        while (mas <3 && (info[mas] = txt.ReadLine()) != null)
        {
            mas++;
            
        }
        txt.Close();


        if (info[0].Replace("Language","") == ": ru ;")
        {

            helper[0] = "Enter (ентер) : враг начинает бить ваши карты.\r\n";
            helper[1] = "Space (пробел) : закончить мой ход.\r\n";
            helper[3] = "Space (пробел) : беру карти, не могу отбить.\r\n";
            helper[2] = "Enter (ентер) : отбил карты противника, очистить стол если он больше не подбросит.\r\n";
 
        }

        Button[] m_v = new Button[3];

        for (int x = 0; x < 3; x++)
        {

            m_v[x] = new Button();

            if (info[0].Replace("Language", "") == ": ru ;")
            { m_v[x].BackgroundImage = new Bitmap(adrec + "\\img\\m_v" + x + "_ru.jpg"); }
            else m_v[x].BackgroundImage = new Bitmap(adrec + "\\img\\m_v" + x + ".jpg");
            m_v[x].Width = 200;
            m_v[x].Height = 50;
            m_v[x].Left = (SystemInformation.PrimaryMonitorSize.Width / 2) - (m_v[x].Width / 2);
            this.Controls.Add(m_v[x]);
        }
     

        m_v[0].Top = SystemInformation.PrimaryMonitorSize.Height / 2;
        m_v[1].Top = m_v[0].Top + m_v[0].Height + 30;
        m_v[2].Top = m_v[1].Top + m_v[1].Height + 30;

        m_v[1].Click += new EventHandler(chench_program);
        m_v[2].Click += new EventHandler(end_program);
        m_v[0].Click += new EventHandler(start_game);

    }



    void end_program(object sender, EventArgs e)
    {
        Application.Exit();
    }


    void start_game(object z, EventArgs x)
    {
        vidbuv = false;
        voroga_kartu.Clear();
        ctil_kartu.Clear();
        moi_kartu.Clear();
        my.Controls.Clear();
        ctol.Controls.Clear();
        her.Controls.Clear();
        ed = false;
        col_kart = 36;
        h = "";
        m = "";
        nacrt = false;
        Random vvubir_kozura = new Random();
        kozur = vvubir_kozura.Next(4);
        this.Controls.Clear();

        Bitmap b = new Bitmap(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
        Graphics zz;
        zz = Graphics.FromImage(b);
        zz.DrawImage(new Bitmap(adrec + "\\img\\game.jpg"), 0, 0, SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);

        this.Controls.Add(go_end);
        this.BackgroundImage = b;

        string imag = "1";
        string roz = ".png";

        if (info[1].Replace("Type of card", "") == ": 2 ;") {
            imag = "2";
            roz = ".jpg";
        }

        for (int i = 0; i < 36; i++)
        {
            
            Graphics res;
            koloda[i] = new Karta();
            koloda[i].vigre = true;
            if (imag == "2") {
                koloda[i].img.BorderStyle = BorderStyle.FixedSingle;
            }
            koloda[i].img.MouseClick += new MouseEventHandler(ctil_ua);
            koloda[i].img.Image = new Bitmap(71,96);
            res = Graphics.FromImage(koloda[i].img.Image);
            res.DrawImage(new Bitmap(adrec + "\\img\\"+imag+"\\"+(i + 1).ToString() + roz),0,0,71,96);
            koloda[i].vkolode = true;
            koloda[i].vaga = (i - (i % 4)) / 4;
            koloda[i].img.Width = 71;
            koloda[i].img.Height = 96;
            koloda[i].img.Name = i.ToString();
            
            switch (i + 1)
                {

                    case 1:
                    case 5:
                    case 9:
                    case 13:
                    case 17:
                    case 21:
                    case 25:
                    case 29:
                    case 33: koloda[i].mast = 0; break;
                    case 2:
                    case 6:
                    case 10:
                    case 14:
                    case 18:
                    case 22:
                    case 26:
                    case 30:
                    case 34: koloda[i].mast = 1; break;
                    case 3:
                    case 7:
                    case 11:
                    case 15:
                    case 19:
                    case 23:
                    case 27:
                    case 31:
                    case 35: koloda[i].mast = 2; break;
                    case 4:
                    case 8:
                    case 12:
                    case 16:
                    case 20:
                    case 24:
                    case 28:
                    case 32:
                    case 36: koloda[i].mast = 3; break;

                }

        if (koloda[i].mast == kozur) { koloda[i].kozur = true; }


            
        }
        gra();
    }

    void ctil_koloda() {

        col_vigre = 0;

        for (int s = 0; s < koloda.Length; s++)
        {
            if (koloda[s].vigre) { col_vigre++; }

        }


        if (!ed)
        {
            Bitmap opa =  new Bitmap(adrec+"\\img\\mast_"+kozur.ToString()+".png");
            mast.Image = opa;

            if (info[2].Replace("Help", "") == ": true ;")
            {
                this.Controls.Add(help);
            }
            this.Controls.Add(up);
            up.Visible = false;
            this.Controls.Add(my);
            this.Controls.Add(col);
            this.Controls.Add(mast);
            this.Controls.Add(face);
            this.Controls.Add(her);
            this.Controls.Add(ctol);

            ed = true;
        }

    }

    void gra() {

        bool mono = true;
        ctil_koloda();
        gra_sortyvannua();




            if (moi_kartu.Count > 0 && voroga_kartu.Count > 0)
            {
                if (!vidbuv) { gra_miuxid(); }
                else if (vidbuv)
                {
                    moe.Clear();
                    gra_voroxid();
                }


            }

            else if (col_vigre > 0)
            {



                if (moi_kartu.Count == 0 && voroga_kartu.Count > 0) {
                    mono = false;
                    if (info[0].Replace("Language", "") == ": ua ;")
                {
                    h = "Кінець гри";
                    m = "Ви виграли. Почати нову гру?";
                }
                else
                {
                    h = "Конец игры";
                    m = "Вы победили. Начать новую игру?";
                }
                }
                else {
                    mono = false;
                    if (info[0].Replace("Language", "") == ": ua ;")
                    {
                        h = "Кінець гри";
                        m = "Ви програли. Почати нову гру?";
                    }
                    else
                    {
                        h = "Конец игры";
                        m = "Вы проиграли. Начать новую игру?";
                    } 
                    
                }

            }
            else {
                mono = false;
                if (info[0].Replace("Language", "") == ": ua ;")
                    {
                        h = "Кінець гри";
                        m = "Ничія. Почати нову гру?";
                    }
                    else
                    {
                        h = "Конец игры";
                        m = "Ничья. Начать новую игру?";
                    } 
            }


            DialogResult oo = new DialogResult();
            

            if (!mono)
            {
                mono = true;
                oo = MessageBox.Show(m, h, MessageBoxButtons.YesNo);



                if (oo == DialogResult.Yes)
                {
                    this.Controls.Clear();
                    start_game(new Object(), new EventArgs());
                }
                else if (oo == DialogResult.No)
                {
                    this.Controls.Clear();
                    menu();
                }
            }

    }

    void gra_voroxid()
    {
        int min = 99;
        int vaga;

        help.Text = helper[2];
        help.Text += "\r\n" + helper[3];
        
        int ex = 0;
        List<int> num = new List<int>();

        for (int id = 0; id < voroga_kartu.Count; id++)
        {
            if (voroga_kartu[id].mast == kozur) {
                vaga = voroga_kartu[id].vaga + 20;
            }
            else vaga = voroga_kartu[id].vaga; 
            if (vaga < min) {
                min = voroga_kartu[id].vaga;
                ex = id;
            
            }
        }

        num.Add(ex);

        for (int id = 0; id < voroga_kartu.Count; id++)
        {
            if(voroga_kartu[ex].vaga == voroga_kartu[id].vaga &&id != ex && moi_kartu.Count > num.Count){
                num.Add(id);
            }
        }

        for (int end = 0; end < num.Count; end++) {
            
            ctol.Controls.Add(voroga_kartu[num[end]].img,end,0);
            her.Controls.Remove(voroga_kartu[num[end]].face);
            voroga_kartu[num[end]].img.Top = top_center;
            ctil_kartu.Add(voroga_kartu[num[end]]);
            voroga_kartu[num[end]].img.Left = voroga_kartu[num[end]].face.Left;

        }
        can_go2 = true;
        num.Sort();
            int ccol = 0;
        for (int end = 1; ccol < num.Count; end++)
        {
            ccol ++;
            voroga_kartu.RemoveAt(num[num.Count-end]);
        }

    }

    void gra_sortyvannua() 
    
    {


  
        Random all = new Random();
        int ind = 0;
        int por = 0;

        if (vidbuv)
        {
            for (; moi_kartu.Count < 6 && col_kart > 0; por++)
            {





                do { ind = all.Next(36); }
                while (!koloda[ind].vkolode);


                col_kart--;
                moi_kartu.Add(koloda[ind]);
                koloda[ind].vkolode = false;
                my.Controls.Add(koloda[ind].img);


            }

            ind = 0;
            por = 0;

            for (; voroga_kartu.Count < 6 && col_kart > 0; por++)
            {


                do { ind = all.Next(36); }
                while (!koloda[ind].vkolode);


                col_kart--;
                her.Controls.Add(koloda[ind].face);
                voroga_kartu.Add(koloda[ind]);
                koloda[ind].vkolode = false;

            }

        }
        else {

          

            for (; voroga_kartu.Count < 6 && col_kart > 0; por++)
            {


                do { ind = all.Next(36); }
                while (!koloda[ind].vkolode);


                col_kart--;
                her.Controls.Add(koloda[ind].face);
                voroga_kartu.Add(koloda[ind]);
                koloda[ind].vkolode = false;

            }

            ind = 0;
            por = 0;

            for (; moi_kartu.Count < 6 && col_kart > 0; por++)
            {





                do { ind = all.Next(36); }
                while (!koloda[ind].vkolode);


                col_kart--;
                moi_kartu.Add(koloda[ind]);
                koloda[ind].vkolode = false;
                my.Controls.Add(koloda[ind].img);


            }

        
        
        
        }
        col.Text = col_kart.ToString();





        bool z = false;
        while (!z) {

            z = true;

            for (int h = 0; h < my.Controls.Count-1; h++)
            {
                var po1 = my.Controls.GetChildIndex(my.Controls[h]);
                var po2 = my.Controls.GetChildIndex(my.Controls[h]);


                if (Convert.ToInt32(my.Controls[h].Name) > Convert.ToInt32(my.Controls[h+1].Name))
                {

                    my.Controls.SetChildIndex(my.Controls[h], po2);
                    my.Controls.SetChildIndex(my.Controls[h + 1], po1);
                    z = false;
                }

            }

        }




    }
    void gra_miuxid() {

        my_kart_only.Clear();
        can_go1 = true;
        help.Text = helper[0];
        help.Text += "\r\n"+helper[1];
        makx = voroga_kartu.Count;
 
    
    }


    void enter_cick(object sender, KeyEventArgs e)
    {
        for (int l = 0; l < ctil_kartu.Count; l++)
        {
            ctil_kartu[l].img.BorderStyle = BorderStyle.None;
        }


        if (can_go && ctil_kartu.Count > 0)
        {

            List<int> del = new List<int>();
            bool next = true;

            if (e.KeyCode == Keys.Enter)
            {
                int ctil_kol = ctil_kartu.Count;
                for (int ctil = 0; ctil < ctil_kol && next; ctil++)
                {
                    bool clon = false;
                    int min = 99;
                    int id = 0;
                    int min_koz = 99;

                    for (int w = 0; w < my_kart_only.Count; w++)
                    {
                        
                        if (my_kart_only[w].ToString() == ctil_kartu[ctil].img.Name)
                        {
                            clon = true;
                        }
                    }
                    if (clon&&my_kart_only.Count>0)
                    {
                        for (int ryki = 0; ryki < voroga_kartu.Count; ryki++)
                        {

                            if (voroga_kartu[ryki].vaga < min_koz && voroga_kartu[ryki].kozur && min == 99 && !ctil_kartu[ctil].kozur)
                            {

                                min_koz = voroga_kartu[ryki].vaga;
                                id = ryki;
                            }

                            if (ctil_kartu[ctil].vaga < voroga_kartu[ryki].vaga && voroga_kartu[ryki].vaga < min && voroga_kartu[ryki].mast == ctil_kartu[ctil].mast)
                            {
                                min = voroga_kartu[ryki].vaga;
                                id = ryki;
                            }

                        }


                        if (min == 99) { min = min_koz; }


                        if (min != 99)
                        {

                            my_kart_only.RemoveAt(0);
                            her.Controls.Remove(voroga_kartu[id].face);
                            ctol.Controls.Add(voroga_kartu[id].img,ctol.GetColumn(ctil_kartu[ctil].img),1);
                            voroga_kartu[id].img.Top = top_center - 60;
                            voroga_kartu[id].img.Left = ctil_kartu[ctil].img.Left;
                            ctil_kartu.Add(voroga_kartu[id]);
                            voroga_kartu.RemoveAt(id);

                            can_go1 = true;

                            end = true;

                        }
                        else
                        {

                            can_go1 = true;
                            next = false;

                            for (int ex = 0; ex < ctil_kartu.Count; ex++)
                            {

                                her.Controls.Add(ctil_kartu[ex].face);
                                ctil_kartu[ex].face.Top = 0;
                                ctil_kartu[ex].face.Left = (600 + (ex * 50) + 50);
                                voroga_kartu.Add(ctil_kartu[ex]);
                            }

                            ctol.Controls.Clear();
                            up.Visible = true;
                            System.Windows.Forms.Timer clock = new System.Windows.Forms.Timer();

                            clock.Interval = 3000;
                            clock.Start();
                            clock.Tick += new EventHandler(clock_Tick);
                            ctil_kartu.Clear();
                            end = false;
                            gra();
                        
                        }

                    }



                }
            }
        }
        else if (can_go2)
        {

            if (ctil_kartu.Count % 2 == 0 && e.KeyCode == Keys.Enter && moe.Count == ctil_kartu.Count)
            {

                bool doc = vrag_docidoc();

                if (!doc)
                {
                    for (int n = 0; n < ctil_kartu.Count; n++)
                    {

                        ctil_kartu[n].vigre = false;

                    }
                    for (int h = 0; h < moi_kartu.Count; h++)
                    {
                        moi_kartu[h].img.BorderStyle = BorderStyle.None;
                    }
                    ctol.Controls.Clear();
                    ctil_kartu.Clear();
                    can_go = true;
                    vidbuv = false;
                    can_go1 = true;
                    can_go2 = false;
                    moe.Clear();
                    gra();

                }
                else
                {
                    List<int> num = new List<int>();
                    for (int n = 0; n < moe.Count; n++)
                    {
                        for (int id = 0; id < voroga_kartu.Count; id++)
                        {
                           if (voroga_kartu[id].vaga == koloda[moe[n]].vaga&&num.Count<=moi_kartu.Count)
                            {

                                num.Add(id);
                                ctol.Controls.Add(voroga_kartu[id].img,ctol.Controls.Count,0);
                                her.Controls.Remove(voroga_kartu[id].face);
                                ctil_kartu.Add(voroga_kartu[id]);
                            }
                        }
                    }


                    can_go2 = true;
                    num.Sort();
                    int ccol = 0;
                    for (int end = 1; ccol < num.Count; end++)
                    {
                        ccol++;
                        voroga_kartu.RemoveAt(num[num.Count - end]);
                    }
                
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                for (int h = 0; h < moi_kartu.Count; h++)
                {
                    moi_kartu[h].img.BorderStyle = BorderStyle.None;
                }

                for (int re = 0; re < ctil_kartu.Count; re++)
                {
                    my.Controls.Add(ctil_kartu[re].img);
                    ctil_kartu[re].img.Top = SystemInformation.PrimaryMonitorSize.Height - ctil_kartu[re].img.Height;
                    moi_kartu.Add(ctil_kartu[re]);

                }
                ctol.Controls.Clear();
                ctil_kartu.Clear();
                can_go = false;
                vidbuv = true;
                can_go1 = false;
                moe.Clear();
                gra();

            }
        }
    }


    void clock_Tick(object sender, EventArgs e)
    {
        up.Visible = false;
        
    }

    void ctil_ua(object z, MouseEventArgs x) {

        int lasth = 99;
        PictureBox ths = (PictureBox)z;
        bool ok = false;
        bool okey = false;
        bool zero = false;
        int lastm = 99;

        for (int ax = 0; ax < moe.Count; ax++) {
            if (moe[ax] == Convert.ToInt32(ths.Name)) { zero = true; }
        
        }

        for (int f = 0; f < moi_kartu.Count; f++) { if (ths.Name == moi_kartu[f].img.Name) { ok = true; lastm = my_num; my_num = Convert.ToInt32(ths.Name); } }
        for (int f = 0; f < ctil_kartu.Count; f++) { if (!zero && ths.Name == ctil_kartu[f].img.Name) { okey = true; lasth = he_naum; he_naum = Convert.ToInt32(ths.Name); } }


            if (can_go1 && ok)
            {
                bool tak = false;

                for (int num = 0; num < ctil_kartu.Count; num++)
                {
                    if (makx>0 && ctil_kartu[num].vaga == koloda[Convert.ToInt32(ths.Name)].vaga && ctil_kartu[num].img.Name != ths.Name) { tak = true; }
                   
                }
                if (ctil_kartu.Count == 0) { tak = true;}
                
                if (tak)
                {

                    makx--;
                    ctol.Controls.Add(ths,ctol.Controls.Count,0);

                    
                    ths.Top =  top_center;
                    my.Controls.Remove(ths);
                    ctil_kartu.Add(koloda[Convert.ToInt32(ths.Name)]);
                    can_go = true;
                    my_kart_only.Add(Convert.ToInt32(ths.Name));

                    for (int id = 0; id < moi_kartu.Count; id++)
                    {


                        if (moi_kartu[id].img.Name == ths.Name) { moi_kartu.RemoveAt(id); }

                    }

                }

      
            }

            else if (can_go2 && ok || can_go2 && okey)
            {

                if (he_naum != 99&&okey) {
                    if (lasth != 99) { koloda[lasth].img.BorderStyle = BorderStyle.None; } 
                    koloda[he_naum].img.BorderStyle = BorderStyle.Fixed3D;
                }

                if (my_num != 99 && ok)
                {
                    if (lastm != 99) { koloda[lastm].img.BorderStyle = BorderStyle.None; }
                    koloda[my_num].img.BorderStyle = BorderStyle.Fixed3D;
                }


                if (my_num != 99 && he_naum != 99 && koloda[my_num].vaga > koloda[he_naum].vaga && koloda[my_num].mast == koloda[he_naum].mast || my_num != 99 && he_naum != 99 && koloda[my_num].mast == kozur && koloda[he_naum].mast != kozur)
                {
                    moe.Add(he_naum);
                    moe.Add(my_num);


                    ctol.Controls.Add(koloda[my_num].img,ctol.GetColumn(koloda[he_naum].img),1);
                    my.Controls.Remove(koloda[my_num].img);
                    ctil_kartu.Add(koloda[my_num]);

                    for (int i = 0; i < moi_kartu.Count; i++)
                    {
                        if (Convert.ToInt32(moi_kartu[i].img.Name) == my_num)
                        {
                            moi_kartu.RemoveAt(i);

                        }
                    }
                    koloda[my_num].img.BorderStyle = BorderStyle.None;
                    koloda[he_naum].img.BorderStyle = BorderStyle.None;
                    my_num = 99;
                    he_naum = 99;

                }
                

            }
    }


    void start_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Space && end)
        {
            end = false;
            can_go = false;
            can_go1 = false;
            
            for (int y = 0; y < ctil_kartu.Count; y++)
            {
                ctil_kartu[y].vigre = false;
                ctol.Controls.Clear();
            }
            ctil_kartu.Clear();

            if (can_go1 == true)
            { vidbuv = false; }
            else vidbuv = true;
            gra();
        }
    }


    bool vrag_docidoc()
    {
        bool z = false;

        for (int n = 0; n < moe.Count;n++)
        {
            for (int id = 0; id < voroga_kartu.Count; id++)
            {
                if (voroga_kartu[id].vaga == koloda[moe[n]].vaga)
                {
                    z= true;
                }
            }
        }


        return z;
    }


    void up_dow(object sender, MouseEventArgs e)
    {
        if (col_vigre > 0)
        {
            if (e.Delta > 0)
            {
                if (my.VerticalScroll.Value >= 20)
                {
                    my.VerticalScroll.Value = my.VerticalScroll.Value - 20;
                }
                else my.VerticalScroll.Value = 0;

            }

            else if (e.Delta < 0)
            {
                my.VerticalScroll.Value = my.VerticalScroll.Value + 20;
            }
        }

    }


    void go_end_MouseClick(object sender, MouseEventArgs e)
    {
        this.Controls.Clear();
        menu();
    }


    void chench_program(object z, EventArgs x) {
        
        this.Controls.Clear();
        PictureBox back = new PictureBox();
        back.Left = SystemInformation.PrimaryMonitorSize.Width / 5;
        back.Top = SystemInformation.PrimaryMonitorSize.Height / 5;
        back.Width = SystemInformation.PrimaryMonitorSize.Width - (back.Left*2);
        back.Height = SystemInformation.PrimaryMonitorSize.Height - (back.Top*2);
        back.BorderStyle = BorderStyle.FixedSingle;
        back.Image = new Bitmap(SystemInformation.PrimaryMonitorSize.Width-(back.Left*2),SystemInformation.PrimaryMonitorSize.Height-(back.Top*2));
        Graphics back_img = Graphics.FromImage(back.Image);

        back_img.DrawImage(new Bitmap(adrec+"\\img\\chench.jpg"),0,0,SystemInformation.PrimaryMonitorSize.Width-(back.Left*2),SystemInformation.PrimaryMonitorSize.Height-(back.Top*2));

        PictureBox rem = new PictureBox();

        rem.Top = back.Top;
        rem.Left = back.Left;
        rem.Width = 30;
        rem.Height = 30;
        rem.Image = new Bitmap(adrec+"\\img\\rem.jpg");
        rem.MouseClick += new MouseEventHandler(save_all);
        this.Controls.Add(rem);

        string[] zn = new string[3];
        this.ForeColor = Color.White;

        nacrt = true;

        s.WrapContents = f.WrapContents = false;
        s.Width = f.Width = 200;
        s.Height = f.Height = 120;
        s.Top= f.Top = 160+back.Top;
        s.Left = back.Left + 60;
        f.Left = s.Left + s.Width + 20;
        s.BackColor = f.BackColor = Color.Gray;

        s.Scroll += new ScrollEventHandler(s_Scroll);
        f.Scroll += new ScrollEventHandler(s_Scroll);

        if (info[1].Replace("Type of card","") == ": 1 ;") {
            f.BackColor = Color.Gold;
        }
        else if (info[1].Replace("Type of card", "") == ": 2 ;")
        { s.BackColor = Color.Gold; }

        for (int d = 1; d < 36; d++) {
            Bitmap w = new Bitmap((adrec + "\\img\\1\\" + d.ToString() + ".png"));
            PictureBox  ww = new PictureBox();
            ww.MouseClick += new MouseEventHandler(f_MouseClick);
            ww.Width = 71;
            ww.Height = 96;
            ww.Image = w;
            f.Controls.Add(ww);

            w = new Bitmap((adrec + "\\img\\2\\" + d.ToString() + ".jpg"));
            ww = new PictureBox();
            ww.MouseClick += new MouseEventHandler(s_MouseClick);
            ww.Width = 71;
            ww.Height = 96;
            ww.BorderStyle = BorderStyle.FixedSingle;
            ww.Image = w;
            
            s.Controls.Add(ww);
        }

            s.AutoScroll = f.AutoScroll = true;
        
        this.Controls.Add(s);
        this.Controls.Add(f);

        leng[0] = new RadioButton();
        leng[1] = new RadioButton();
        leng[0].Parent = back;
        leng[1].Parent = back;
        leng[0].Text = "Руская";
        leng[1].Text = "Українська";
        leng[0].Left = back.Left + 65;
        leng[1].Left = leng[0].Left +leng[0].Width+20;
        leng[0].Top = back.Top + 60;
        leng[1].Top = leng[0].Top;
        leng[0].BackgroundImage = leng[1].BackgroundImage = new Bitmap(adrec+"\\img\\radio.jpg");
        leng[0].TextAlign = ContentAlignment.MiddleCenter;
        leng[1].TextAlign = ContentAlignment.MiddleCenter;



        this.Controls.Add(leng[0]);
        this.Controls.Add(leng[1]);

        if (info[0].Replace("Language", "") == ": ua ;")
        {
            zn[0] = "Виберіть мову гри";
            zn[1] = "Виберіть малюнок карт";
            zn[2] = "Справка по грі (правий нижній куток)";
            leng[1].Select();
        }
        else if (info[0].Replace("Language", "") == ": ru ;")
        {
            zn[0] = "Выберите язык игры";
            zn[1] = "Выберите рисунок карт";
            zn[2] = "Справка в игре (правый нижный угол).";
            leng[0].Select();
        }

        back_img.DrawString(zn[0], new Font("Comic Sans MS", 13F, FontStyle.Regular), new SolidBrush(Color.White), 65, 30);
        back_img.DrawString(zn[1], new Font("Comic Sans MS", 13F, FontStyle.Regular), new SolidBrush(Color.White), 65, 120);


        if (info[2].Replace("Help", "") == ": true ;")
        {
            hp.Checked = true;
        }



        hp.Top = s.Top + s.Height + 50;
        hp.Width = 250;
        hp.BackColor = Color.Black;
        hp.Left = s.Left;
        hp.Text = zn[2];
        hp.BackgroundImageLayout = ImageLayout.Stretch;
        hp.BackgroundImage = new Bitmap(adrec + "\\img\\che.jpg");
        this.Controls.Add(hp);
        

        this.Controls.Add(back);
    }
    
    void save_all(object z, MouseEventArgs x) {
        string res = "";
        if (leng[1].Checked)
        {
            res = "Language: ua ;\r\n";
        }
        else {
            res = "Language: ru ;\r\n";
        }
        if (f.BackColor == Color.Gold) {
            res += "Type of card: 1 ;\r\n";
        }
        else {
            res+= "Type of card: 2 ;\r\n";
        }
        if (hp.Checked)
        {
            res += "Help: true ;";
        }
        else {
            res += "Help: false ;";
        }

        StreamWriter rez = iff.CreateText();
        rez.Write(res);
        rez.Close();
        this.Controls.Clear();
        menu();
    }
    void s_MouseClick(object sender, MouseEventArgs e)
    {
        s.BackColor = Color.Gold; 
        f.BackColor = Color.Gray;
    }
    void f_MouseClick(object sender, MouseEventArgs e)
    {
        f.BackColor = Color.Gold;
        s.BackColor = Color.Gray;
    }
    void s_Scroll(object sender, ScrollEventArgs e)
    {
        if (nacrt) {
            f.HorizontalScroll.Value = s.HorizontalScroll.Value;
            s.HorizontalScroll.Value = f.HorizontalScroll.Value;
        }

    }
}

