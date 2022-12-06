// Classe Joueur
//
// Le joueur principal
//
//
// Création : 2022/11/19
// Par : Frédérik Taleb
// Modification : 2022/11/24
// Par : Frédérik Taleb
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinal_A22
{
    public class Joueur
    {
        // attributs (public)
        // un nom 
        public string name;
        // (0)att, (1)matt, (2)def, (3)mdef, (4)hp, (5)hpTotal des entiers
        public int[] stats = new int[5];
        // habilete un attribut du type Habilete
        public Habilete habilete;

        // Constructeur
        //
        // reçoit tous les attributs en paramètre sauf l'habilete
        // assigne les paramètres aux attributs correspondants
        public Joueur(string[] stats)
        {
            this.name = stats[0];
            this.stats[0] = Convert.ToInt32(stats[1]);
            this.stats[1] = Convert.ToInt32(stats[2]);
            this.stats[2] = Convert.ToInt32(stats[3]);
            this.stats[3] = Convert.ToInt32(stats[4]);
            this.stats[4] = Convert.ToInt32(stats[5]);
        } //Fait à tester


        // enumererActions
        //
        // renvoie un string contenant les actions possibles, séparées par des virgules OK
        // exemple : "attaquer,boule de feu" ok
        // "Attaquer" est TOUJOURS la première action possible ok
        // Ajouter l'habileté seulement si l'attribut tour de l'habileté est à 0
        //
        // @return string une chaîne de caractères contenant les actions possibles séparées par des virgules

        public string enumererActions ()
        {
            string enumerer = "Attaquer";

            if (this.habilete.tour <= 0)
            {
                enumerer += "," + this.habilete.nom;
            }


            return enumerer;
        } //Fait à tester

        // attaquer
        //
        // renvoie la statistique d'attaque
        public int attaquer ()
        {
            return this.stats[0];
        } //Fait à tester


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
                dmg -= this.stats[3];
            }
            // sinon
            else
            {
                // les dommages finaux sont le dommage - la défense
                dmg -= this.stats[2];
            }

            // si les dommages finaux sont plus grands que 0
            if (dmg <0) 
            {
                // diminuer les points de vie du nombre de points de dommage final
                this.stats[4] -= dmg;
            }

        } //Fait à tester 

        // estVivant
        //
        // détermine s'il reste des points de vie
        // 
        // @return bool vrai s'il reste des points de vie, faux sinon

        public bool estVivant()
        {
            bool vivant = true;

            if (this.stats[0] <= 0)
            {
                vivant = false;
            }

            return vivant;
        } //Fait à tester

        // enumererStats
        // 
        // envoie un string contenant le nom et les points de vie
        // "Nom : {0}, Hp : {1}"
        //
        // @return string le nom et les points de vie selon le format établi

        public string enumererStats ()
        { 
            return "Nom : " + this.name + ", Hp : " +this.stats[4];
        } //Fait à tester

    }
}
