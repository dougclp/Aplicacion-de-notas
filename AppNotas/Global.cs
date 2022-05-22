using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNotas {
    class Global {
        public static List<Estudiante> estudiantes = new List<Estudiante>() {
            new Estudiante(1,"Abel","Gerardo","Aballay",4),
            new Estudiante(1,"Abel","Gerardo","Aballay",5),
            new Estudiante(1,"Abel","Gerardo","Aballay",1),
            new Estudiante(1,"Abel","Gerardo","Aballay",6),
            new Estudiante(1,"Abel","Gerardo","Aballay",3),
            new Estudiante(1,"Abel","Gerardo","Aballay",2),
            new Estudiante(2,"Abellay","","Ricardo",4),
            new Estudiante(2,"Abellay","","Ricardo",5),
            new Estudiante(2,"Abellay","","Ricardo",1),
            new Estudiante(2,"Abellay","","Ricardo",6),
            new Estudiante(2,"Abellay","","Ricardo",3),
            new Estudiante(2,"Abellay","","Ricardo",2),
            new Estudiante(3,"Arredondo","","Roberto",4),
            new Estudiante(3,"Arredondo","","Roberto",5),
            new Estudiante(3,"Arredondo","","Roberto",1),
            new Estudiante(3,"Arredondo","","Roberto",6),
            new Estudiante(3,"Arredondo","","Roberto",3),
            new Estudiante(3,"Arredondo","","Roberto",2),
            new Estudiante(4,"Carrizo","Martín","Matías",4),
            new Estudiante(4,"Carrizo","Martín","Matías",5),
            new Estudiante(4,"Carrizo","Martín","Matías",1),
            new Estudiante(4,"Carrizo","Martín","Matías",6),
            new Estudiante(4,"Carrizo","Martín","Matías",3),
            new Estudiante(4,"Carrizo","Martín","Matías",2),
            new Estudiante(5,"Castro","Mairo","Leonardo",5),
            new Estudiante(5,"Castro","Mairo","Leonardo",4),
            new Estudiante(5,"Castro","Mairo","Leonardo",1),
            new Estudiante(5,"Castro","Mairo","Leonardo",6),
            new Estudiante(5,"Castro","Mairo","Leonardo",3),
            new Estudiante(5,"Castro","Mairo","Leonardo",2),
            new Estudiante(6,"Cruz","Molina","Germán",4),
            new Estudiante(6,"Cruz","Molina","Germán",5),
            new Estudiante(6,"Cruz","Molina","Germán",1),
            new Estudiante(6,"Cruz","Molina","Germán",6),
            new Estudiante(6,"Cruz","Molina","Germán",3),
            new Estudiante(6,"Cruz","Molina","Germán",2),
            new Estudiante(7,"Díaz","Gonzalo","Dianmán",4),
            new Estudiante(7,"Díaz","Gonzalo","Dianmán",5),
            new Estudiante(7,"Díaz","Gonzalo","Dianmán",1),
            new Estudiante(7,"Díaz","Gonzalo","Dianmán",6),
            new Estudiante(7,"Díaz","Gonzalo","Dianmán",3),
            new Estudiante(7,"Díaz","Gonzalo","Dianmán",2),
            new Estudiante(8,"Godoy","José","Luis",4),
            new Estudiante(8,"Godoy","José","Luis",5),
            new Estudiante(8,"Godoy","José","Luis",1),
            new Estudiante(8,"Godoy","José","Luis",6),
            new Estudiante(8,"Godoy","José","Luis",3),
            new Estudiante(8,"Godoy","José","Luis",2),
            new Estudiante(9,"Gutierrez-Oro","José","Miguel",4),
            new Estudiante(9,"Gutierrez-Oro","José","Miguel",5),
            new Estudiante(9,"Gutierrez-Oro","José","Miguel",1),
            new Estudiante(9,"Gutierrez-Oro","José","Miguel",6),
            new Estudiante(9,"Gutierrez-Oro","José","Miguel",3),
            new Estudiante(9,"Gutierrez-Oro","José","Miguel",2),
            new Estudiante(10,"López","Juan","Sebastian",4),
            new Estudiante(10,"López","Juan","Sebastian",5),
            new Estudiante(10,"López","Juan","Sebastian",1),
            new Estudiante(10,"López","Juan","Sebastian",6),
            new Estudiante(10,"López","Juan","Sebastian",3),
            new Estudiante(10,"López","Juan","Sebastian",2),
            new Estudiante(11,"Mallea","Leandro ","David",4),
            new Estudiante(11,"Mallea","Leandro ","David",5),
            new Estudiante(11,"Mallea","Leandro ","David",1),
            new Estudiante(11,"Mallea","Leandro ","David",6),
            new Estudiante(11,"Mallea","Leandro ","David",3),
            new Estudiante(11,"Mallea","Leandro ","David",2),
            new Estudiante(12,"Mercado","Paulo ","G",4),
            new Estudiante(12,"Mercado","Paulo ","G",5),
            new Estudiante(12,"Mercado","Paulo ","G",1),
            new Estudiante(12,"Mercado","Paulo ","G",6),
            new Estudiante(12,"Mercado","Paulo ","G",3),
            new Estudiante(12,"Mercado","Paulo ","G",2),
            new Estudiante(13,"Ontiveros","Matías ","",4),
            new Estudiante(13,"Ontiveros","Matías ","",5),
            new Estudiante(13,"Ontiveros","Matías ","",1),
            new Estudiante(13,"Ontiveros","Matías ","",6),
            new Estudiante(13,"Ontiveros","Matías ","",3),
            new Estudiante(13,"Ontiveros","Matías ","",2),
            new Estudiante(14,"Parada","Abel ","Gastón",4),
            new Estudiante(14,"Parada","Abel ","Gastón",5),
            new Estudiante(14,"Parada","Abel ","Gastón",1),
            new Estudiante(14,"Parada","Abel ","Gastón",6),
            new Estudiante(14,"Parada","Abel ","Gastón",3),
            new Estudiante(14,"Parada","Abel ","Gastón",2),
            new Estudiante(15,"Roel","Ahumada ","Pedro",4),
            new Estudiante(15,"Roel","Ahumada ","Pedro",5),
            new Estudiante(15,"Roel","Ahumada ","Pedro",1),
            new Estudiante(15,"Roel","Ahumada ","Pedro",6),
            new Estudiante(15,"Roel","Ahumada ","Pedro",3),
            new Estudiante(15,"Roel","Ahumada ","Pedro",2),
            new Estudiante(16,"Silva","Ricardo ","Gabriel",4),
            new Estudiante(16,"Silva","Ricardo ","Gabriel",5),
            new Estudiante(16,"Silva","Ricardo ","Gabriel",1),
            new Estudiante(16,"Silva","Ricardo ","Gabriel",6),
            new Estudiante(16,"Silva","Ricardo ","Gabriel",3),
            new Estudiante(16,"Silva","Ricardo ","Gabriel",2),
            new Estudiante(17,"Tello","Ricardo ","Edgardo",4),
            new Estudiante(17,"Tello","Ricardo ","Edgardo",5),
            new Estudiante(17,"Tello","Ricardo ","Edgardo",1),
            new Estudiante(17,"Tello","Ricardo ","Edgardo",6),
            new Estudiante(17,"Tello","Ricardo ","Edgardo",3),
            new Estudiante(17,"Tello","Ricardo ","Edgardo",2),
            new Estudiante(18,"Canizo","Natalia ","Paola",4),
            new Estudiante(18,"Canizo","Natalia ","Paola",5),
            new Estudiante(18,"Canizo","Natalia ","Paola",1),
            new Estudiante(18,"Canizo","Natalia ","Paola",6),
            new Estudiante(18,"Canizo","Natalia ","Paola",3),
            new Estudiante(18,"Canizo","Natalia ","Paola",2),
            new Estudiante(19,"Carrizo","Eugenia ","",4),
            new Estudiante(19,"Carrizo","Eugenia ","",5),
            new Estudiante(19,"Carrizo","Eugenia ","",1),
            new Estudiante(19,"Carrizo","Eugenia ","",6),
            new Estudiante(19,"Carrizo","Eugenia ","",3),
            new Estudiante(19,"Carrizo","Eugenia ","",2),
            new Estudiante(20,"Castro","Yanina ","Anahi",4),
            new Estudiante(20,"Castro","Yanina ","Anahi",5),
            new Estudiante(20,"Castro","Yanina ","Anahi",1),
            new Estudiante(20,"Castro","Yanina ","Anahi",6),
            new Estudiante(20,"Castro","Yanina ","Anahi",3),
            new Estudiante(20,"Castro","Yanina ","Anahi",2),
            new Estudiante(21,"González","Daniela ","",4),
            new Estudiante(21,"González","Daniela ","",5),
            new Estudiante(21,"González","Daniela ","",1),
            new Estudiante(21,"González","Daniela ","",6),
            new Estudiante(21,"González","Daniela ","",3),
            new Estudiante(21,"González","Daniela ","",2),
            new Estudiante(22,"Molina","Pamela ","E",4),
            new Estudiante(22,"Molina","Pamela ","E",5),
            new Estudiante(22,"Molina","Pamela ","E",1),
            new Estudiante(22,"Molina","Pamela ","E",6),
            new Estudiante(22,"Molina","Pamela ","E",3),
            new Estudiante(22,"Molina","Pamela ","E",2),
            new Estudiante(23,"Ormeño","Carolina ","",4),
            new Estudiante(23,"Ormeño","Carolina ","",5),
            new Estudiante(23,"Ormeño","Carolina ","",1),
            new Estudiante(23,"Ormeño","Carolina ","",6),
            new Estudiante(23,"Ormeño","Carolina ","",3),
            new Estudiante(23,"Ormeño","Carolina ","",2),
            new Estudiante(24,"Palacio","Guardia ","Eliana",4),
            new Estudiante(24,"Palacio","Guardia ","Eliana",5),
            new Estudiante(24,"Palacio","Guardia ","Eliana",1),
            new Estudiante(24,"Palacio","Guardia ","Eliana",6),
            new Estudiante(24,"Palacio","Guardia ","Eliana",3),
            new Estudiante(24,"Palacio","Guardia ","Eliana",2),
            new Estudiante(25,"Quiroga","Susana ","B",4),
            new Estudiante(25,"Quiroga","Susana ","B",5),
            new Estudiante(25,"Quiroga","Susana ","B",1),
            new Estudiante(25,"Quiroga","Susana ","B",6),
            new Estudiante(25,"Quiroga","Susana ","B",3),
            new Estudiante(25,"Quiroga","Susana ","B",2),
            new Estudiante(26,"Torres","Silvina ","",4),
            new Estudiante(26,"Torres","Silvina ","",5),
            new Estudiante(26,"Torres","Silvina ","",1),
            new Estudiante(26,"Torres","Silvina ","",6),
            new Estudiante(26,"Torres","Silvina ","",3),
            new Estudiante(26,"Torres","Silvina ","",2),
            new Estudiante(27,"Molina","Luis ","",4),
            new Estudiante(27,"Molina","Luis ","",5),
            new Estudiante(27,"Molina","Luis ","",1),
            new Estudiante(27,"Molina","Luis ","",6),
            new Estudiante(27,"Molina","Luis ","",3),
            new Estudiante(27,"Molina","Luis ","",2),
            new Estudiante(28,"Lopez"," ","",4),
            new Estudiante(28,"Lopez"," ","",5),
            new Estudiante(28,"Lopez"," ","",1),
            new Estudiante(28,"Lopez"," ","",6),
            new Estudiante(28,"Lopez"," ","",3),
            new Estudiante(28,"Lopez"," ","",2),
            new Estudiante(29,"Molina","Cintia","",4),
            new Estudiante(29,"Molina","Cintia","",5),
            new Estudiante(29,"Molina","Cintia","",1),
            new Estudiante(29,"Molina","Cintia","",6),
            new Estudiante(29,"Molina","Cintia","",3),
            new Estudiante(29,"Molina","Cintia","",2),
            new Estudiante(30,"Muñoz","Mario","",4),
            new Estudiante(30,"Muñoz","Mario","",5),
            new Estudiante(30,"Muñoz","Mario","",1),
            new Estudiante(30,"Muñoz","Mario","",6),
            new Estudiante(30,"Muñoz","Mario","",3),
            new Estudiante(30,"Muñoz","Mario","",2),

        };

        public static List<Materia> materia = new List<Materia>() {
            new Materia(1,"Historia"),
            new Materia(2,"Ingles"),
            new Materia(3,"Lengua"),
            new Materia(4,"Matemáticas"),
            new Materia(5,"Proyecto"),
            new Materia(6,"Tecnología")
        };

        public static List<Nota> nota = new List<Nota>() {
            //Abel Gerardo
            new Nota(1,7,7,7,4,1),
            new Nota(2,8,5,6.5,5,1),
            new Nota(3,5,8,6.5,1,1),
            new Nota(4,6,9,7.5,6,1),
            new Nota(5,7,8,7.5,3,1),
            new Nota(6,10,6,8,2,1),

            //Ricardo Aballay
            new Nota(7,8,5,6.5,4,2),
            new Nota(8,4,6,5,5,2),
            new Nota(9,6,5,5.5,1,2),
            new Nota(10,8,7,7.5,6,2),
            new Nota(11,6,7.5,6.75,3,2),
            new Nota(12,7.5,9,8.25,2,2),

            //Roberto Arredondo
            new Nota(13,7,7,7,4,3),
            new Nota(14,8,5,6.5,5,3),
            new Nota(15,5,8,6.5,1,3),
            new Nota(16,6,9,7.5,6,3),
            new Nota(17,7,8,7.5,3,3),
            new Nota(18,10,6,8,2,3),
            
            //Martín Matías Carrizo
            new Nota(19,8,5,6.5,4,4),
            new Nota(20,4,6,5,5,4),
            new Nota(21,6,5,5.5,1,4),
            new Nota(22,8,7,7.5,6,4),
            new Nota(23,6,7.5,6.75,3,4),
            new Nota(24,7.5,9,8.25,2,4),

            //Mairo Leonardo Castro
            new Nota(25,7,7,7,4,5),
            new Nota(26,8,5,6.5,5,5),
            new Nota(27,5,8,6.5,1,5),
            new Nota(28,6,9,7.5,6,5),
            new Nota(29,7,8,7.5,3,5),
            new Nota(30,10,6,8,2,5),

            //German Cruz-Molina
            new Nota(31,8,5,6.5,4,6),
            new Nota(32,4,6,5,5,6),
            new Nota(33,6,5,5.5,1,6),
            new Nota(34,8,7,7.5,6,6),
            new Nota(35,6,7.5,6.75,3,6),
            new Nota(36,7.5,9,8.25,2,6),

            //Gonzalo Damián Díaz
            new Nota(37,7,7,7,4,7),
            new Nota(38,8,5,6.5,5,7),
            new Nota(39,5,8,6.5,1,7),
            new Nota(40,6,9,7.5,6,7),
            new Nota(41,7,8,7.5,3,7),
            new Nota(42,10,6,8,2,7),

            //José Luis Godoy
            new Nota(43,8,5,6.5,4,8),
            new Nota(44,4,6,5,5,8),
            new Nota(45,6,5,5.5,1,8),
            new Nota(46,8,7,7.5,6,8),
            new Nota(47,6,7.5,6.75,3,8),
            new Nota(48,7.5,9,8.25,2,8),

            //José Miguel Gutierrez-Oro
            new Nota(49,7,7,7,4,9),
            new Nota(50,8,5,6.5,5,9),
            new Nota(51,5,8,6.5,1,9),
            new Nota(52,6,9,7.5,6,9),
            new Nota(53,7,8,7.5,3,9),
            new Nota(54,10,6,8,2,9),

            //Juan sebastián Lopez
            new Nota(55,8,5,6.5,4,10),
            new Nota(56,4,6,5,5,10),
            new Nota(57,6,5,5.5,1,10),
            new Nota(58,8,7,7.5,6,10),
            new Nota(59,6,7.5,6.75,3,10),
            new Nota(60,7.5,9,8.25,2,10),

            //Leandro David Mallea
            new Nota(61,7,7,7,4,11),
            new Nota(62,8,5,6.5,5,11),
            new Nota(63,5,8,6.5,1,11),
            new Nota(64,6,9,7.5,6,11),
            new Nota(65,7,8,7.5,3,11),
            new Nota(66,10,6,8,2,11),

            //Paulo G. Mercado
            new Nota(67,8,5,6.5,4,12),
            new Nota(68,4,6,5,5,12),
            new Nota(69,6,5,5.5,1,12),
            new Nota(70,8,7,7.5,6,12),
            new Nota(71,6,7.5,6.75,3,12),
            new Nota(72,7.5,6,8.25,2,12),

            //Matías Ontiveros
            new Nota(73,7,7,7,4,13),
            new Nota(74,8,5,6.5,5,13),
            new Nota(75,5,8,6.5,1,13),
            new Nota(76,6,9,7.5,6,13),
            new Nota(77,7,8,7.5,3,13),
            new Nota(78,10,6,8,2,13),

            //Abel Gastón Parada
            new Nota(79,8,5,6.5,4,14),
            new Nota(80,4,6,5,5,14),
            new Nota(81,6,5,5.5,1,14),
            new Nota(82,8,7,7.5,6,14),
            new Nota(83,6,7.5,6.75,3,14),
            new Nota(84,7.5,9,8.25,2,14),

            //Pedro Roel-Ahumada
            new Nota(85,7,7,7,4,15),
            new Nota(86,8,5,6.5,5,15),
            new Nota(87,5,8,6.5,1,15),
            new Nota(88,6,9,7.5,6,15),
            new Nota(89,7,8,7.5,3,15),
            new Nota(90,10,6,8,2,15),

            //Ricardo Gabriel  Silva
            new Nota(91,8,5,6.5,4,16),
            new Nota(92,4,6,5,5,16),
            new Nota(93,6,5,5.5,1,16),
            new Nota(94,8,7,7.5,6,16),
            new Nota(95,6,7.5,6.75,3,16),
            new Nota(96,7.5,9,8.25,2,16),

            //Renzo Edgardo Tello
            new Nota(97,7,7,7,4,17),
            new Nota(98,8,5,6.5,5,17),
            new Nota(99,5,8,6.5,1,17),
            new Nota(100,6,9,7.5,6,17),
            new Nota(101,7,8,7.7,3,17),
            new Nota(102,10,6,8,2,17),

            //Natalia Paola Canizo
            new Nota(103,8,5,6.5,4,18),
            new Nota(104,4,6,5,5,18),
            new Nota(105,6,5,6.5,1,18),
            new Nota(106,8,7,7.5,6,18),
            new Nota(107,6,7.5,6.75,3,18),
            new Nota(108,7.5,9,8.25,2,18),

            //Eugenia Carrizo
            new Nota(109,7,7,7,4,19),
            new Nota(110,8,5,6.5,5,19),
            new Nota(111,5,8,6.5,1,19),
            new Nota(112,6,9,7.5,6,19),
            new Nota(113,7,8,7.5,3,19),
            new Nota(114,10,6,8,2,19),

            //Yanina Anahi Castro
            new Nota(115,8,5,6.5,4,20),
            new Nota(116,4,6,5,5,20),
            new Nota(117,6,5,5.5,1,20),
            new Nota(118,8,7,7.5,6,20),
            new Nota(119,6,7.5,6.75,3,20),
            new Nota(120,7.5,9,8.25,2,20),

            //Daniela Gonzalez
            new Nota(121,7,7,7,4,21),
            new Nota(122,8,5,6.5,5,21),
            new Nota(123,5,8,6.5,1,21),
            new Nota(124,6,9,7.5,6,21),
            new Nota(125,7,8,7.5,3,21),
            new Nota(126,10,6,8,2,21),

            //Pamela E. Molina
            new Nota(127,8,5,6.5,4,22),
            new Nota(128,4,6,5,5,22),
            new Nota(129,6,5,5.5,1,22),
            new Nota(130,8,7,7.5,6,22),
            new Nota(131,6,7.5,6.75,3,22),
            new Nota(132,7.5,9,8.25,2,22),

             //Carolina Ormeño
            new Nota(133,8,5,6.5,4,23),
            new Nota(134,4,6,5,5,23),
            new Nota(135,6,5,5.5,1,23),
            new Nota(136,8,7,7.5,6,23),
            new Nota(137,6,7.5,6.75,3,23),
            new Nota(138,7.5,9,8.25,2,23),

            //Eliana Palacio Guardia
            new Nota(139,8,5,6.5,4,24),
            new Nota(140,4,6,5,5,24),
            new Nota(141,6,5,5.5,1,24),
            new Nota(142,8,7,7.5,6,24),
            new Nota(143,6,7.5,6.75,3,24),
            new Nota(144,7.5,9,8.25,2,24),

             //Susana B. Quiroga
            new Nota(145,7,7,7,4,25),
            new Nota(146,8,5,6.5,5,25),
            new Nota(147,5,8,6.5,1,25),
            new Nota(148,6,9,7.5,6,25),
            new Nota(149,7,8,7.5,3,25),
            new Nota(150,10,6,8,2,25),

             //Silvina Torres
            new Nota(151,8,5,6.5,4,26),
            new Nota(152,4,6,5,5,25),
            new Nota(153,6,5,5.5,1,25),
            new Nota(154,8,7,7.5,6,26),
            new Nota(155,6,7.5,6.5,3,26),
            new Nota(156,7.5,9,8.25,2,26),

            //Luis Molina
            new Nota(157,5,8.5,6.75,4,27),
            new Nota(158,7,6.5,6.75,5,27),
            new Nota(159,8,9.5,8.75,1,27),
            new Nota(160,6.5,7.5,7,6,27),
            new Nota(161,9,7.5,8.25,3,27),
            new Nota(162,8.5,6,7.25,2,27),

            //Lopez
            new Nota(163,6.5,7.5,7,4,27),
            new Nota(164,9,7.5,8.25,5,27),
            new Nota(165,8.5,6,7.25,1,27),
            new Nota(166,7,5.5,6.25,6,27),
            new Nota(167,6,7.5,6.75,3,27),
            new Nota(168,5,9,7,2,27),

            //Cintia Molina
            new Nota(169,5.5,6.5,6,4,28),
            new Nota(170,7.5,8,7.75,5,28),
            new Nota(171,6.5,8,7.25,1,28),
            new Nota(172,5.5,7,6.25,6,28),
            new Nota(173,6.5,7.5,7,3,28),
            new Nota(174,8,7,7.5,2,28),

            //Muñoz Mario
            new Nota(175,7,8.5,7.75,4,29),
            new Nota(176,9,7.5,8.25,5,29),
            new Nota(177,9.5,6,7.75,1,29),
            new Nota(178,7,5.5,6.25,6,29),
            new Nota(179,6.5,8.5,7.25,3,29),
            new Nota(180,5.5,7,6.25,2,29)


        };
    }

    public class Estudiante {
        int id;
        string apellidos;
        string primerNombre;
        string segundoNombre;

        int idMateria;

        public Estudiante(int id, string apellidos, string primerNombre, string segundoNombre, int idMateria) {
            this.id = id;
            this.Apellidos = apellidos;
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;

            this.idMateria = idMateria;
        }

        public int Id { get => id; set => id = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }

        public int Idmateria { get => idMateria; set => idMateria = value; }
    }

    public class Materia {
        int id;
        string nombreMateria;


        public Materia(int id, string nombreMateria) {
            this.id = id;
            this.NombreMateria = nombreMateria;

        }

        public int Id { get => id; set => id = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }


    }
    public class Nota {
        int idNota;
        double primerNota;
        double segundaNota;
        double notaFinal;
        int idMateria;
        int idEstudiante;

        public Nota(int idNota, double primerNota, double segundaNota, double notaFinal, int idMateria, int idEstudiante) {
            this.IdNota = idNota;
            this.PrimerNota = primerNota;
            this.SegundaNota = segundaNota;
            this.NotaFinal = notaFinal;
            this.IdMateria = idMateria;
            this.IdEstudiante = idEstudiante;
        }

        public int IdNota { get => idNota; set => idNota = value; }
        public double PrimerNota { get => primerNota; set => primerNota = value; }
        public double SegundaNota { get => segundaNota; set => segundaNota = value; }
        public double NotaFinal { get => notaFinal; set => notaFinal = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
    }
}