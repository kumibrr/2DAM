using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_Premio_planeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] years = { 2015, 2016, 2017, 2018, 2019, 2020 };
            cmbYear.Items.AddRange(years.Cast<object>().ToArray());
            cmbYear.SelectedIndex = years.Length - 1;
        }

        string[,] winners = {
                { "Alicia Giménez Bartlett","Dolores Redondo","Javier Sierra","Santiago Posteguillo","Javier Cercas","Eva García Sáenz de Urturi" },
                { "Hombres desnudos", "Todo esto te daré", "El fuego invisible","Yo, Julia","Terra Alta", "Aquitania" },
                { "HombresDesnudos", "TodoEstoTedare","ElFuegoInvisible","YoJulia","TerraAlta","Aquitania" }
            };

        string[,] finalist = {
                { "Daniel Sánchez Arévalo", "Marcos Chicot", "Cristina López Barrio", "Ayanta Barilli", "Manuel Vilas", "Sandra Barneda" },
                { "La isla de Alice", "El asesinato de Sócrates", "Niebla en Tánger", "Un mar violeta oscuro", "Alegría", "Un océano para llegar a ti" },
                { "LAIslaDeAlice", "ElAsesinatodeSocrates", "NieblaEnTanger", "UnMarVioletaOscuro", "Alegria", "UnOceanollegaParaTi" }
            };

        string[] sipnosisG = new string[] {
                "Nadie puede imaginar hasta qué punto los tiempos convulsos son capaces de convertirnos en quienes ni siquiera imaginamos que podríamos llegar a ser. Hombres desnudos es una novela sobre el presente que estamos viviendo, donde hombres treintañeros pierden su trabajo y pueden acabar haciendo estriptis en un club, y donde cada vez más mujeres priman su carrera profesional sobre cualquier compromiso sentimental o familiar. En esta historia, esos hombres y esas mujeres entran en contacto y en colisión, y lo harán con unas consecuencias imprevisibles. \r\n\r\n Sexo, amistad, inocencia y maldad en una combinación tan armónica como desasosegante.",
                "En el escenario majestuoso de la Ribeira Sacra, Álvaro sufre un accidente que acabará con su vida. Cuando Manuel, su marido, llega a Galicia para reconocer el cadáver, descubre que la investigación sobre el caso se ha cerrado con demasiada rapidez. El rechazo de su poderosa familia política, los Muñiz de Dávila, le impulsa a huir pero le retiene el alegato contra la impunidad que Nogueira, un guardia civil jubilado, esgrime contra la familia de Álvaro, nobles mecidos en sus privilegios, y la sospecha de que ésa no es la primera muerte de su entorno que se ha enmascarado como accidental. Lucas, un sacerdote amigo de la infancia de Álvaro, se une a Manuel y a Nogueira en la reconstrucción de la vida secreta de quien creían conocer bien. \r\n\r\n La inesperada amistad de estos tres hombres sin ninguna afinidad aparente ayuda a Manuel a navegar entre el amor por quien fue su marido y el tormento de haber vivido de espaldas a la realidad, blindado tras la quimera de su mundo de escritor. Empezará así la búsqueda de la verdad, en un lugar de fuertes creencias y arraigadas costumbres en el que la lógica nunca termina de atar todos los cabos.",
                "David Salas, un prometedor lingüista del Trinity Collage de Dublín, se encuentra, después de aterrizar en Madrid para pasar sus vacaciones, con Victoria Goodman, una vieja amiga de sus abuelos y con su joven ayudante, una misteriosa historiadora del arte. Ese hecho trastocará sus planes y lo empujará a una sorprendente carrera por averiguar qué ha sucedido con una de los alumnos de la escuela de literatura que regenta lady Goodman. Para su sorpresa, la clave parece esconderse en el mito del grial y su vinculación con España. \r\n\r\n Remotas iglesias románicas de los Pirineos, colecciones de arte en Barcelona, libros antiguos y extraños códigos en piedra se alinean en una trama llena de intriga que nos hará pensar sobre el origen de toda inspiración, literatura y arte verdaderos",
                "192d.C. Varios hombres luchan por un imperio, pero Julia, hija de reyes, madre de césares y esposa de emperador, piensa en algo más grande: una dinastía. Roma está bajo el control de Cómodo, un emperador loco. El Senado se conjura para terminar con el tirano y los gobernadores militares más poderosos podrían dar un golpe de Estado. Albino es Britania, Severo en el Danubio o Nigro en Siria. Cómodo retiene a su esposa para evitar su rebelión y Julia, la mujer de Severo, se convierte así en rehén.\r\n\r\n De pronto, Roma arde. Un incendio asola la ciudad. ¿Es un desastre o una oportunidad? Cinco hombres se disponen a luchar a muerte por el poder. Creen que la partida está a punto de empezar. Pero para Julia la partida está a punto de empezar. Sabe que solo una mujer puede forjar una dinastía.",
                "Un crimen terrible sacude la apacible comarca de la Terra Alta: los propietarios de su mayor empresa, Gráficas Adell, aparecen asesinados tras haber sido sometidos a atroces torturas. Se encarga del caso Melchor Marín, un joven policía y lector voraz llegado desde Barcelona cuatro años atrás, con un oscuro pasado a cuestas que le ha convertido en una leyenda del cuerpo y que cree haber enterrado bajo su vida feliz como marido de la bibliotecaria del pueblo y padre de una niña llamada Cosette, igual que la hija de Jean Valjean, el protagonista de su novela favorita: Los miserables.\r\n\r\n Partiendo de ese suceso, y a través de una narración trepidante y repleta de personajes memorables, esta novela se convierte en una lúcida reflexión sobre el valor de la ley, la posibilidad de la justicia y la legitimidad de la venganza, pero sobre todo en la epopeya de un hombre en busca de su lugar en el mundo.",
                "1137. El duque de Aquitania —la región más codiciada de Francia— aparece muerto en Compostela. El cuerpo queda de color azul y con la marca del «águila de sangre», una ancestral tortura normanda. Su hija Eleanor decide vengarse y para ello se casa con el hijo del que cree su asesino: Luy VI el Gordo, rey de Francia. \r\n\r\n Pero el propio rey muere durante la boda en idénticas circunstancias. Eleanor y Luy VII intentarán averiguar, junto con los gatos aquitanos —los épicos espías de los duques—, quién quiere a los inexpertos reyes en el trono. \r\n\r\n Décadas antes de la muerte del duque de Aquitania, un niño sin nombre es abandonado en un bosque por sus cinco madres. Acaso un monstruo, o tal vez un santo, el pequeño superviviente acabará convirtiéndose en uno de los hombres más excepcionales del medievo europeo."
              };

        string[] sipnosisF = new string[] {
                "Cuando Chris muere en un accidente de coche sospechosamente lejos de donde debía estar, la vida de su mujer, Alice, con una niña de seis años y otra en camino, se desmorona. Incapaz de asumir la pérdida y con el temor de que tal vez su relación perfecta haya sido una mentira, se obsesiona con descubrir de dónde venía Chris y qué secreto escondía. Reconstruye el último viaje de su marido con la ayuda de las cámaras de seguridad de los establecimientos por donde este había pasado, hasta llegar al epicentro del misterio: Robin Island, en Cape Cod, Massachusetts, una pequeña y, solo en apariencia, apacible isla que modifi cará profundamente a Alice mientras busca respuesta a la pregunta: ¿Qué hacía Chris en la isla?\r\n\r\nLa isla de Alice oscila entre el thriller y el viaje emocional. Una historia de superación y una peripecia absorbente y cautivadora.",
                "Grecia, siglo v a. C. Un oscuro oráculo vaticina la muerte de Sócrates. Un recién nacido es condenado a morir por su propio padre. Una guerra encarnizada entre Atenas y Esparta desangra Grecia.\r\n\r\nEl asesinato de Sócrates recrea magistralmente la época más extraordinaria de nuestra historia. Madres que luchan por sus hijos, amores imposibles y soldados tratando de sobrevivir se entrelazan de un modo fascinante con los gobernantes, artistas y pensadores que convirtieron Grecia en la cuna de nuestra civi-lización. A lo largo de las páginas de esta absorbente novela, brilla con luz propia la figura inigualable de Sócrates, el hombre cuya vida y muerte nos inspiran desde hace siglos, el filósofo que marca un antes y un después en la historia de la humanidad.",
                "El 24 de diciembre de 1951 Paul Dingle desapareció en el puerto de Tánger sin que se llegara a saber qué fue de él. Sesenta y cuatro años después, Flora Gascón sospecha que es el mismo hombre con el que ha tenido una aventura en Madrid y del que se ha enamorado. El nexo entre ellos: Niebla en Tánger, la novela que Paul tenía sobre su mesilla de noche.\r\n\r\nFlora viajará hasta esta ciudad mágica y llena de secretos en busca de la autora de la novela, la única que puede decirle quién es en verdad su amante y cómo encontrarlo. Pronto se da cuenta de que es ella misma quien debe escribir el final de la historia, pues en esa aventura también está en juego su identidad; es un viaje al fondo de sí misma.\r\n\r\nNiebla en Tánger es una bella historia de amor y misterio en una ciudad cosmopolita y mágica, con un pasado fascinante que envolverá al lector.",
                "Una maldición recorre las vidas de Elvira, Ángela y Caterina: elegir a hombres que no la supieron amar.\r\n\r\nElvira se casó con Evaristo, un demonio que sembró el miedo y la locura. Su hija Ángela renunció a sí misma por un marido ausente, siempre en los brazos de otras, incapaz de ocuparse ni de ella ni de sus hijas. Y la indómita Caterina, tercera de la saga, acabó enamorada de otro ser diabólico, sin tener conciencia del peligro que corría. Sólo Ayanta, última descendiente, se enfrentará a su herencia transitando el camino de los recuerdos y de la verdad.\r\n\r\nUn mar violeta oscuro es la historia de una rebelión ante la amenaza de ese destino que parece ineludible, el de muchas mujeres sometidas a las condiciones del tiempo que les tocó vivir, el de tantas protagonistas anónimas que lucharon por ser felices, por ser libres.",
                "Desde el corazón de su memoria, un hombre que arrastra tantos años de pasado como ilusiones de futuro, ilumina, a través de sus recuerdos, su historia, la de su generación y la de un país. Una historia que a veces duele, pero que siempre acompaña.\r\n\r\nEl éxito desbordante de su última novela embarca al protagonista en una gira por todo el mundo. Un viaje con dos caras, la pública, en la que el personaje se acerca a sus lectores, y la íntima, en la que aprovecha cada espacio de soledad para rebuscar su verdad. Una verdad que ve la luz después de la muerte de sus padres, su divorcio y su vida junto a una nueva mujer, una vida en la que sus hijos se convierten en la piedra angular sobre la que pivota la necesidad inaplazable de encontrar la felicidad.\r\n\r\nA medio camino entre la confesión y la autoficción, el autor escribe una historia que toma impulso en el pasado y se lanza hacia lo aún no sucedido. Una búsqueda esperanzada de la alegría.",
                "Solo hay algo más fuerte que la voluntad: el amor\r\n\r\nUna novela tierna y atrevida sobre los secretos familiares y las emociones silenciadas.\r\n\r\nTras la muerte de su madre, Gabriele vuelve al pueblo de los veranos de su infancia. Allí le espera su padre, con el que no habla desde hace años. Juntos se disponen a cumplir el último deseo de Greta: que las tres personas más importantes de su vida —su marido, su única hija y su cuñada— esparzan sus cenizas en un lugar donde fueron felices. Los secretos que Greta desvela en las cartas que deja a su familia terminarán con el silencio entre padre e hija y, como en un dominó, alterarán la vida de todos y propiciarán un encuentro inesperado que hará que Gabriele descubra que en la vulnerabilidad se halla la magia de la vida.\r\n\r\n¿Y si el destino de las personas tendiera un hilo invisible que las conecta con aquellos que deben encontrar? ¿Y si la vida solo fuera un viaje para encontrarlos?"
              };

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources");
            picWinnerBookCover.Image = Image.FromFile(filePath + "\\" + winners[2, cmbYear.SelectedIndex] + ".jpg");
            lblWinnerWriter.Text = winners[0, cmbYear.SelectedIndex];
            lblWinnerBookTitle.Text = winners[1, cmbYear.SelectedIndex];
            txtWinnerSynopsis.Text = this.sipnosisG[cmbYear.SelectedIndex];


            picFinalistBookCover.Image = Image.FromFile(filePath + "\\" + finalist[2, cmbYear.SelectedIndex] + ".jpg");
            lblFinalistWriter.Text = finalist[0, cmbYear.SelectedIndex];
            lblFinalistBookTitle.Text = finalist[1, cmbYear.SelectedIndex];
            txtFinalistSynopsis.Text = this.sipnosisF[cmbYear.SelectedIndex];
        }

    }

}
