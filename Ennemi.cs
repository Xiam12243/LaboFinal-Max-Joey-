// Classe Ennemi
//
// Un ennemi
//
// L'ennemi a les mêmes statistiques et méthodes que le joueur avec quelques différences
//  - pas d'habilete
//  - pas de méthode pour donner les actions, l'ennemi ne fait qu'attaquer
//  - un nouvel attribut dit si les attaques de l'ennemi sont magiques ou non
//  - une méthode pour dire si les attaques sont magiques ou non, basée sur l'attribut
//
// Création : 2022/11/19
// Par : Frédérik Taleb
// Modification : 2022/11/24
// Par : Frédérik Taleb

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinal_A22
{
    public class Ennemi
    {
        // attributs (public)
        // un nom 
        public string nom;
        // att, matt, def, mdef, hp des entiers
        public int att;
        public int matt;
        public int def;
        public int mdef;
        public int hp;
        // magique un attribut qui détermine si les attaques sont magiques ou non
        public bool magique;

        // Constructeur
        //
        // reçoit tous les attributs en paramètre
        // assigne les paramètres aux attributs correspondants
        public Ennemi(string[] stats)
        {
            this.nom = stats[0];
            this.att = Convert.ToInt32(stats[1]);
            this.matt = Convert.ToInt32(stats[2]);
            this.def = Convert.ToInt32(stats[3]);
            this.mdef = Convert.ToInt32(stats[4]);
            this.hp = Convert.ToInt32(stats[5]);
            this.magique= Convert.ToBoolean(stats[6]);
        } //Fait à vérifier

        public Ennemi(string nom, int att, int matt, int def, int mdef, int hp, bool magique)
        {
            this.nom = nom;
            this.att = att;
            this.matt = matt;
            this.def = def;
            this.mdef = mdef;
            this.hp = hp;
            this.magique = magique;
        }

        // estMagique
        //
        // retourne l'attribut magique 
        //
        // @return bool vrai si les attaques sont magiques, faux sinon
        public bool estMagique()
        {
            return this.magique;
        } //Fait à vérifier

        // attaquer
        //
        // renvoie la statistique d'attaque
        public int attaquer()
        {
            return this.att;
        } //Fait à vériier

        // defendre
        //
        // selon l'attaque, magique ou non, diminue les points de dommage du nombre de points de défense
        // diminiue les points de vie selon les dommages finaux, les dommages finaux ne peuvent pas être sous 0
        //
        // @param bool magique vrai pour une attaque magique, faux sinon
        // @param int dmg      le nombre de point de dommage avant la réduction par la défense
        public void defendre(bool magique, int dmg)
        {
            // si l'attaque est magique
            if (magique = true) 
            {
                // les dommages finaux sont le dommage - la défense magique
                dmg -= this.mdef;
            }


            // sinon
            else
            {
                // les dommages finaux sont le dommage - la défense
                dmg -= this.def;
            }



            // diminuer les points de vie du nombre de points de dommage final
            if (dmg > 0)
            {
                this.hp -= dmg;
            }

        } //Fait à vérifier

        // estVivant
        //
        // détermine s'il reste des points de vie
        // 
        // @return bool vrai s'il reste des points de vie, faux sinon

        public bool estVivant ()
        {
            bool vivant = true;
            if (this.hp <= 0)
            {
                vivant = false;
            }


            return vivant;
        } //Fait à vérifier

        // enumererStats
        // 
        // envoie un string contenant le nom et les points de vie
        // "Nom : {0}, Hp : {1}"
        //
        // @return string le nom et les points de vie selon le format établi
        public string enumererStats()
        {
            string message = "nom : " + this.nom + ", Hp : " + this.hp;

            return message;
        } //Fait à vérifier
    }
}
