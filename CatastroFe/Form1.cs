using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace CatastroFe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] locs = { "Greg. Perez de denis 0101", "Gato Colorado 0102", "San Bernardo 0103", "Pozo Borrado 0104", "Tostado 0105", "Logrono 0106", "Esteban Rams 0107", "Montefiore 0108", "Juan De Garay 0109", "Villa Minetti 0110", "Santa Margarita 0111", "Vera 0202", "La Gallareta 0203", "Margarita 0204", "Calchaqui 0205", "Toba 0206", "Fortin Olmos 0207", "Canada Ombu 0208", "Golondrina 0209", "Intiyaco 0210", "Garabato 0211", "Los Amores 0212", "Tartagal 0213", "Florencia 0302", "El Rabon 0303", "Villa Guillermina 0304", "Las Toscas 0305", "S. Antonio De Obligado 0306", "Tacuarendi 0307", "Villa Ocampo 0308", "Villa Ana 0309", "Ing. Chanourdie 0312", "El Sombrerito 0313", "Arroyo Ceibal 0314", "Las Garzas 0315", "Lanteri 0316", "Avellaneda 0319", "Reconquista 0320", "El Araz 0321", "Berna 0322", "Malabrigo 0323", "Los Laureles 0324", "La Sarita 0326", "Guadalupe Norte 0327", "Nicanor Molina 0328", "Romang 0401", "Colonia Durand 0402", "Alejandra 0403", "San Javier 0404", "Cacique Aracaiquin 0405", "La Brava 0406", "Colonia Teresa 0408", "Helvecia 0501", "Cayasta 0502", "Santa Rosa 0503", "Colonia Macias 0505", "Saladero Cabal 0506", "Gomez Cello 0601", "La Camila 0602", "Vera Y Pintado 0603", "San Martin Norte 0604", "La Criolla 0605", "La Penca Y Caraguata 0606", "Crespo 0607", "Silva 0608", "Marcelino Escalada 0609", "Ramayon 0610", "San Justo 0611", "Nare 0612", "San Bernardo 0613", "Angeloni 0614", "Videla 0615", "Esther 0616", "Cayastacito 0617", "Colonia Dolores 0618", "Ceres 0701", "Hersilia 0702", "Ambrosetti 0703", "Huanqueros 0704", "Las Avispas 0705", "Aguara 0706", "Villa Saralegui 0707", "San Cristobal 0708", "Santurce 0709", "Portugalette 0710", "Arrufo 0711", "La Rubia 0712", "Colonia Ana 0713", "Villa Trinidad 0714", "Colonia Rosa 0715", "San Guillermo 0716", "Curupaity 0717", "Capivara 0718", "Nanducita 0719", "La Lucila 0720", "Colonia Clara 0721", "Soledad 0722", "Constanza 0723", "Moises Ville 0724", "Monigotes 0725", "Suardi 0726", "Monte Oscuridad 0727", "Colonia Dos Rosas 0728", "Colonia Bossi 0729", "Las Palmeras 0730", "Palacios 0731", "La Cabral 0732", "Virginia 0801", "Maua 0802", "Humberto Primo 0803", "Colonia Raquel 0804", "Tacural 0805", "Tacurales 0806", "Bicha 0807", "Eusebia 0808", "Hugentogler 0809", "Colonia Aldao 0810", "Sunchales 0811", "Ataliva 0812", "Galisteo 0813", "Lehmann 0814", "Egusquiza 0815", "Bigand 0816", "Fidela 0817", "Pueblo Marini 0818", "Ramona 0819", "Coronel Fraga 0820", "Vila 0821", "Colonia Castellanos 0822", "Presidente Roca 0823", "Rafaela 0824", "Bella Italia 0825", "Aurelia 0826", "Susana 0827", "Villa San Jose 0828", "Saguier 0829", "San Antonio 0830", "Sta.Clara Saguier 0831", "Bauer Y Sigel 0832", "Josefina 0833", "Colonia Cello 0834", "Clucellas 0835", "Colonia Iturraspe 0836", "Angelica 0837", "Estacion Clucellas 0838", "Eustolia 0839", "Zenon Pereyra 0840", "Frontera 0841", "Esmeralda 0842", "Garibaldi 0843", "Maria Juana 0844", "Colonia Margarita 0845", "San Vicente 0846", "Elisa 0901", "Jacinto L. Arauz 0902", "La Pelada 0903", "Ituzaingo 0904", "Soutomayor 0905", "Providencia 0906", "Maria Luisa 0907", "Santo Domingo 0908", "Progreso 0909", "Hipatia 0910", "Sarmiento 0911", "Felicia 0912", "Grutly 0913", "Rivadavia 0914", "Cululu 0915", "Esperanza 0916", "Cavourd 0917", "Humboldt 0918", "Nuevo Torino 0919", "Pilar 0920", "Sta.Maria Centro 0921", "Sta.Maria Norte 0922", "San Jeronimo Norte 0923", "Las Tunas 0924", "Pujato Norte 0925", "Frank 0926", "Empalme San Carlos 0927", "Colonia San Jose 0928", "San Agustin 0929", "San Carlos Norte 0930", "San Jeronimo Del Sauce 0931", "Sa Pereyra 0932", "San Mariano 0933", "Sta.Clara B.Vista 0934", "San Carlos Centro 0935", "Matilde 0936", "San Carlos Sud 0937", "Emilia 1001", "Cabal 1002", "Llambi Campbell 1003", "San Pedro Cpo. Andino 1004", "Laguna Paiva 1005", "Nelson 1006", "Candiotti 1007", "Arroyo Aguiar 1008", "Monte Vera 1009", "Recreo 1010", "Santa Fe 1011", "Santo Tome 1012", "Sauce Viejo 1013", "Arroyo Leyes 1015", "San Jose Del Rincon 1016", "Lopez 1101", "Gessler 1102", "Larrechea 1103", "Desvio Arijon 1104", "Coronda 1105", "Loma Alta 1106", "Campo Piaggio 1107", "Galvez 1108", "San Eugenio 1109", "Arocena 1110", "San Fabian 1111", "Irigoyen 1112", "Bernardo De Irigoyen 1113", "Casalengo 1114", "Barrancas 1115", "Monje 1116", "Gaboto 1117", "Maciel 1118", "Estacion Diaz 1119", "San Genaro Norte 1120", "San Genaro 1121", "Centeno 1122", "Castelar 1201", "Crispi 1202", "Sastre 1203", "San M. De Las Escobas 1204", "Colonia Belgrano 1205", "Canada Rosquin 1206", "Traill 1207", "San Jorge 1208", "Las Petacas 1209", "Landeta 1210", "Carlos Pellegrini 1211", "Casas 1212", "Las Bandurrias 1213", "Los Cardos 1214", "El Trebol 1215", "Piamonte 1216", "Maria Susana 1217", "Bouquet 1301", "Las Rosas 1302", "Las Parejas 1303", "Montes De Oca 1304", "Tortugas 1305", "Armstrong 1306", "Clason 1401", "Totoras 1402", "Carrizales 1403", "Oliveros 1404", "Pueblo Andino 1405", "Serodino 1406", "Lucio V. Lopez 1407", "Salto Grande 1408", "Bustinza 1409", "Canada De Gomez 1410", "Correa 1411", "Villa Eloisa 1412", "Timbues 1501", "Puerto San Martin 1502", "San Lorenzo 1503", "Fray Luis Beltran 1504", "Capitan Bermudez 1505", "Ricardone 1506", "Aldao 1507", "Luis Palacios 1508", "Carcarana 1509", "San Jeronimo Sur 1510", "Roldan 1511", "Pujato 1512", "Coronel Arnold 1513", "Fuentes 1514", "Villa Mugueta 1515", "Ibarlucea 1601", "Granadero Baigorria 1602", "Rosario 1603", "Funes 1604", "Zaballa 1605", "Perez 1606", "Soldini 1607", "Villa Gdor. Galvez 1608", "Alvear 1609", "Pinero 1610", "Alvarez 1611", "Munoz 1612", "Acebal 1613", "Carmen Del Sauce 1614", "Coronel Dominguez 1615", "Villa Amelia 1616", "General Lagos 1617", "Arroyo Seco 1618", "Fighiera 1619", "Coronel Bogado 1620", "Albarellos 1621", "Uranga 1622", "Arminda 1623", "Pueblo Esther 1625", "Caferata 1701", "La Chispa 1702", "Murphy 1703", "Chovet 1704", "Canada Del Ucle 1705", "Firmat 1706", "Miguel Torres 1707", "Carreras 1708", "Melincue 1709", "Elortondo 1710", "Carmen 1711", "Chapuy 1712", "Venado Tuerto 1713", "San Francisco 1714", "Maggiolo 1715", "San Eduardo 1716", "Maria Teresa 1717", "Santa Isabel 1718", "Villa Canas 1719", "Hughes 1720", "Labordeboy 1721", "Wheelwright 1722", "Teodolina 1723", "San Gregorio 1724", "Christophersen 1725", "Sancti Spiritu 1726", "Rufino 1727", "Lazzarino 1728", "Aaron Castellanos 1729", "Diego De Alvear 1730", "Amenabar 1731", "Arteaga 1801", "S.J. Esquina 1802", "Arequito 1803", "Los Molinos 1804", "Casilda 1805", "Sanford 1806", "Bigand 1807", "Chabas 1808", "Villada 1809", "Los Quirquinchos 1810", "Beravebu 1811", "Chanar Ladeado 1812", "Godeken 1813", "Bombal 1901", "Alcorta 1902", "Juncal 1903", "Maximo Paz 1904", "Pavon Arriba 1905", "Santa Teresa 1906", "La Vanguardia 1907", "Cepeda 1908", "Sargento Cabral 1909", "Peyrano 1910", "Canada Rica 1911", "General Gelly 1912", "J.B. Molina 1913", "Godoy 1914", "Rueda 1915", "Emp. Villa Constitucion 1916", "Theobald 1917", "Villa Constitucion 1918", "Pavon 1919", };

            foreach (var s in locs)
            {
                cboLocalidad.Items.Add(s);
            }

            cboLocalidad.SelectedIndex = 0;
            cboMapa.SelectedIndex = 0;
        }

        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                urlDownShape.Text = "http://scit.santafe.gov.ar/scitMap/downl.php?mapa=" + cboMapa.SelectedItem.ToString().Split('[', ']')[1] + cboLocalidad.SelectedItem.ToString().Substring(cboLocalidad.SelectedItem.ToString().Length - 4) + "_shp.zip";
            }
            catch (Exception)
            {
                //this gets called when the bar is empty and the split returns undefined and everything explodes.
                //gotta catch'em all.
            }
        }

        private void btnDownShape_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlDownShape.Text);
        }

        private void lnkPasho_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            MessageBox.Show("Un archivo vacio significa que el mapa no existe en el servidor de Catastro.\nIntente con otro mapa u otra localidad","El mapa no existe",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGetPlano_Click(object sender, EventArgs e)
        {
            string innercode = "";
            try
            {
                innercode = getCodigoPlano(txtPlan.Text, txtAn.Text);
            }
            catch (Exception)
            {
                urlPlan.Text = "Error al conseguir el codigo de plano";
                return;
            }

            string filename = "";

            try
            {
                filename = doTheRegex(innercode);
            }
            catch (Exception)
            {
                urlPlan.Text = "Error al conseguir el plano";
                return;
            }

            if (filename.IndexOf("pdf") == -1)
            {
                urlPlan.Text = Regex.Replace(filename, "<.*?>", string.Empty) ;
                return;
            }

            urlPlan.Text = "http://scit.santafe.gov.ar/planos/" + filename;
            System.Diagnostics.Process.Start("http://scit.santafe.gov.ar/planos/" + filename);
        }

        //Convertir "plano año" en el codigo raro de catastro
        private string getCodigoPlano(string pla, string an)
        {
            WebClient client = new WebClient();
            string retval = client.DownloadString("http://scit.santafe.gov.ar/scitMap/obtiene_plano.php?nro_plano=" + pla.TrimStart('0') + "&anio_plano=" + an + "&procedencia=1");
            return retval;
        }

        //Cargar el visualizador de catastro y scrapear el html para sacar el pdf.
        private string doTheRegex(string innercode)
        {
            WebClient client = new WebClient();
            string code = client.DownloadString("http://scit.santafe.gov.ar/planos/verplano3a.php?cla=" + innercode);

            if (code.IndexOf("<FORM ACTION=") == -1) return code;

            var r = new Regex(@"<a href=""(planopdf.php\?ima=img\d*.pdf)&download=1"" target=blank>Descargar Archivo");

            var obj = r.Match(code);

            return obj.Groups[1].Value;
        }

        private void lnkHelpPlano_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
@"Lista de mensajes de error: 

- Error al conseguir el codigo de plano
Hubo un problema al conectarse al servidor de catastro, verifique su conección a internet.

- Error al conseguir el plano 
Hubo un problema al conectarse al servidor de catastro, verifique su conección a internet.

- Error en los datos
El plano existe pero en este momento los dioses del catastro no pueden mostrarlo.

- Los datos para ubicar el Plano son Insuficientes
El plano y/o el año son incorrectos.","Lista de errores",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/miltoncandelero/CatastroFe/");
        }
    }
}
