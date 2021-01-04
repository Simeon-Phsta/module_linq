using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_EF_ECOLECONDUITE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Déclaration d'un nouvel élève
            //    var unEleve = new ELEVE()
            //    {
            //        id = 99,
            //        nom = "MOI",
            //        prenom = "Moimoi",
            //        rue = "Allée des mois",
            //        ville = "MOI",
            //        cp = "99999",
            //        creditHoraire = 25,
            //        dateInscription = new DateTime(2018, 11, 6)
            //    };
            //    //Ajout de l'élève dans la liste gérées par le programme
            //    context.ELEVEs.Add(unEleve);
            //    //Sauvegarde de l'ajout dans la BD
            //    context.SaveChanges();

            //    //Vérification
            //    foreach (ELEVE unE in context.ELEVEs)
            //    {
            //        Console.WriteLine(unE.prenom + " " + unE.nom);
            //    }
            //}

            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer le premier élève
            //    var unE = context.ELEVEs.First<ELEVE>();
            //    //Visualisation du crédit horaire
            //    Console.WriteLine("AVANT MODIFICATION, LE CREDIT HORAIRE DE " + unE.nom + " EST DE : " + unE.creditHoraire);
            //    //Décrémentation du crédit d'une heure
            //    unE.creditHoraire--;
            //    //Contrôle visuel
            //    Console.WriteLine("APRES MODIFICATION, LE CREDIT HORAIRE DE " + unE.nom + " EST DE : " + unE.creditHoraire);
            //    //Sauvegarde de la modification dans la BD
            //    context.SaveChanges();
            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Déclaration d'une nouvelle leçon
            //    var uneL = new LECON()
            //    {
            //        id = "99",
            //        dateLecon = new DateTime(2018, 11, 6),
            //        heure = 15,
            //        duree = 2,
            //        effectueeO_N = false,
            //        idEleve = 1,
            //        idVehicule = "QR963ST"
            //    };
            //    //Ajout de l'élève dans la liste gérées par le programme
            //    context.LECONs.Add(uneL);
            //    //Sauvegarde de l'ajout dans la BD
            //    context.SaveChanges();

            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer la dernière leçon
            //    var uneL = context.LECONs.Find("99");
            //    //Numéro de leçon supprimer
            //    Console.WriteLine("NUMERO DE LA LECON A SUPPRIMER " + uneL.id);
            //    context.LECONs.Remove(uneL);
            //    //Sauvegarde de l'ajout dans la BD
            //    context.SaveChanges();

            //    try
            //    {
            //        uneL = context.LECONs.Find("99");
            //        Console.WriteLine("NUMERO DE LA LECON RECHERCHEE " + uneL.id);

            //    }
            //    catch
            //    {
            //        Console.WriteLine("LA LECON DEMANDEE N'EXISTE PAS ! ");
            //    }
            //}

            //Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    Récupérer le dernier ELEVE ajouté avec LINQ
            //    var req = from e in context.ELEVEs
            //              where e.id == 99
            //              select e;
            //    ELEVE e1 = req.First();
            //    Console.WriteLine("NOM DE L'ELEVE " + e1.nom);

            //    Récupérer le dernier ELEVE ajouté avec LES EXPRESSION LAMBDA
            //    ELEVE e2 = context.ELEVEs.First((ELEVE e3) => e3.id == 99);
            //    Console.WriteLine("NOM DE L'ELEVE " + e2.nom);

            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer la liste des motos dont la cylindrée est de plus de 500
            //    var req = from v in context.VEHICULEs
            //              where v.cylindree > 500
            //              select v;
            //    var liste = req.ToList();
            //    foreach(VEHICULE v in liste)
            //    {
            //        Console.WriteLine(v.id + " " + v.cylindree.ToString());
            //    }
            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer la liste des motos dont la cylindrée est de plus de 500
            //    string nom = "CHAPELIER";
            //    var req = from l in context.LECONs
            //              where l.ELEVE.nom == nom
            //              select l;

            //    Console.WriteLine("NOMBRE DE LECONS DE {0} : {1}", nom, req.Count());

            //    var liste = req.ToList();
            //    foreach (LECON l in liste)
            //    {
            //        Console.WriteLine(l.idVehicule + " - " + l.dateLecon.ToShortDateString());
            //    }
            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer la liste des leçons de CHAPELIER
            //    string nom = "CHAPELIER";
            //    var req = from l in context.LECONs
            //              where l.ELEVE.nom == nom
            //              select l;
            //    Console.WriteLine("NOMBRE DE LECONS DE {0} : {1}", nom, req.Count());

            //    var liste = req.ToList();
            //    foreach (LECON l in liste)
            //    {
            //        Console.Write("\n" + l.ELEVE.nom + " " + l.ELEVE.prenom + " - ");
            //        if (l.VEHICULE.voitureO_N == true)
            //            Console.Write(l.VEHICULE.modele);
            //        else
            //            Console.Write(l.VEHICULE.cylindree);
            //        Console.Write(" - " + l.dateLecon.ToShortDateString());
            //    }
            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer la liste des leçons de CHAPELIER
            //    string nom = "CHAPELIER";
            //    var req = from e in context.ELEVEs.Include("LECONs")
            //              where e.nom == nom
            //              select e;

            //    var liste = req.ToList();
            //    ELEVE el = liste.First();
            //    foreach (var l in el.LECONs)
            //    {
            //        Console.WriteLine("Date : {0} heure : {1}" , l.dateLecon.ToShortDateString(), l.heure);
            //    }
            //}

            ////Initialisation dans la variable context la base de données ECOLECONDUITE
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    //Récupérer la liste des leçons de CHAPELIER
            //    string nom = "CHAPELIER";
            //    var req = from l in context.LECONs
            //              from v in context.VEHICULEs
            //              where l.ELEVE.nom == nom
            //              && l.VEHICULE.id == v.id
            //              select new { date = l.dateLecon, imma = v.id };

            //    var liste = req.ToList();
            //    foreach (var v in liste)
            //    {
            //        Console.WriteLine("Date : {0} Imma : {1}", v.date.ToShortDateString(), v.imma);
            //    }
            //}

            ////Ajouter une leçon avec LINQ
            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    ELEVE elv = context.ELEVEs.First((ELEVE el) => el.id == 1);
            //    VEHICULE veh = context.VEHICULEs.First((VEHICULE v) => v.numImma == "QR963ST");
            //    LECON le = new LECON("44", DateTime.Now, 10, 2, elv, veh);
            //    context.LECONs.Add(le);
            //    context.SaveChanges();
            //    Console.WriteLine("Ajout Bien Effectue");
            //}


            //using (var context = new ECOLECONDUITEEntities())
            //{
            //    string lecon = "5";
            //    var req = from e in context.ELEVEs
            //              from l in context.LECONs
            //              where e.id == l.idEleve
            //              && l.id == lecon
            //              select new { eleve = e, lec = l };
            //    var le = req.First();

            //    le.lec.setEffectuee();
            //    context.SaveChanges();
            //    Console.WriteLine("Modification Effectuee");
            //}

            ////l'heritage n'existe plus 
            //using (var context = new ECOLECONDUITEEntities())
            //{

            //    var m = new MOTO()
            //    {
            //        numImma = "WS568SA",
            //        laCylindree = 900
            //    };


            //    context.VEHICULEs.Add(m);
            //    context.SaveChanges();
            //    Console.WriteLine("ENREGISTREMENT MOTO OK.");
            //}


            Console.ReadKey();
        }

        
    }
    
}
