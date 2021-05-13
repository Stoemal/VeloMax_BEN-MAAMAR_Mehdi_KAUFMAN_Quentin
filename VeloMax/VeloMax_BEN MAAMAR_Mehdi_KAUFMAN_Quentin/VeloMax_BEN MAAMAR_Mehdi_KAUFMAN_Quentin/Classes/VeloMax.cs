﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace VeloMax_BEN_MAAMAR_Mehdi_KAUFMAN_Quentin
{
    public class VeloMax
    {
        #region Attributs
        //Tables
        private List<Velo> velo;
        private List<Piece> piece;
        private List<Commande> commande;
        private List<Fournisseur> fournisseur;
        private List<Client> client;
        private List<Adresse> adresse;
        private List<Programme> programme;

        //Associations
        private List<Tuple<Velo, Piece, int>> liste_assemblage;
        private List<Tuple<Commande, Piece, int>> liste_piece_commande;
        private List<Tuple<Commande, Velo, int>> liste_velo_commande;
        private List<Tuple<Piece, Fournisseur, int>> catalogue;
        // = new List<Tuple<Velo, Piece, int>>();
        #endregion Attributs

        #region Requête
        private string getVelo;
        private string getPiece;
        private string getCommande_entreprise;
        private string getCommande_particulier;
        private string getFournisseur;
        private string getClient_entreprise;
        private string getClient_particulier;
        #endregion Requête

        #region Constructeurs
        public VeloMax()
        {
            getVelo = "select numero_velo as 'Numéro'," +
                " nom_velo as 'Modèle'," +
                "grandeur_velo as 'Taille'," +
                " prix_velo as 'Prix'," +
                " ligne_produit_velo as 'Type'," +
                " DATE_FORMAT(date_introduction_velo, '%Y-%m-%d') as 'Début production'," +
                " DATE_FORMAT(date_discontinuation_velo, '%Y-%m-%d') as 'Fin production'," +
                " stock_velo as 'Stock' from velo;";

            getPiece = "select p.numero_piece as 'Numéro'," +
                " p.numero_piece_catalogue as 'Ref fournisseur'," +
                " p.description_piece as 'Type', " +
                "DATE_FORMAT(p.date_introduction_piece, '%Y-%m-%d') as 'Début production'," +
                "DATE_FORMAT(p.date_discontinuation_piece, '%Y-%m-%d') as 'Fin production'," +
                " p.prix_piece as 'Prix'," +
                " p.delai_approvisionnement_piece as 'Délai'," +
                " p.stock_piece as 'Stock' from piece p;";

            getCommande_entreprise = "select numero_commande as 'Numéro commande'," +
                "DATE_FORMAT(date_commande, '%Y-%m-%d') as 'Date de commande'," +
                "DATE_FORMAT(date_livraison_commande, '%Y-%m-%d') as 'Date de livraison'," +
                "ID_adresse_commande as 'ID adresse'," +
                "c.ID_client_entreprise as 'ID entreprise' " +
                "from commande c " +
                "join client_entreprise ce on ce.ID_client_entreprise = c.ID_client_entreprise; ";

            getCommande_particulier = "select numero_commande as 'Numéro commande'," +
                "DATE_FORMAT(date_commande, '%Y-%m-%d') as 'Date de commande'," +
                "DATE_FORMAT(date_livraison_commande, '%Y-%m-%d') as 'Date de livraison'," +
                "ID_adresse_commande as 'ID adresse'," +
                "c.ID_client_particulier as 'ID particulier' " +
                "from commande c " +
                "join client_particulier ce on ce.ID_client_particulier = c.ID_client_particulier; ";

            getFournisseur = "select siret_fournisseur as 'Siret'," +
               "nom_fournisseur as 'Fournisseur'," +
               "qualite_fournisseur as 'Qualité'," +
               "nom_contact_fournisseur as 'Contact'," +
               "ID_adresse_fournisseur as 'Adresse'" +
               "from fournisseur; ";

            getClient_entreprise = "select ID_client_entreprise as 'ID'," +
                "nom_client_entreprise as 'Entreprise'," +
                "remise_client_entreprise as 'Remise'," +
                "courriel_entreprise as 'Courriel'," +
                "telephone_entreprise as 'Téléphone'," +
                "nom_contact_entreprise as 'Nom contact'," +
                "ID_adresse_client_entreprise as 'ID adresse'" +
                "from client_entreprise;";

            getClient_particulier = "SELECT ID_client_particulier AS 'ID'," +
                "nom_client_particulier AS 'Nom'," +
                "prenom_client_particulier AS 'Prénom'," +
                "DATE_FORMAT(date_adhesion_programme, '%Y-%m-%d') AS 'Date adhésion programme'," +
                "courriel_particulier AS 'Courriel'," +
                "telephone_particulier AS 'Téléphone'," +
                "numero_programme AS 'Numéro programme'," +
                "ID_adresse_client_particulier AS 'Adresse'" +
                "FROM client_particulier; ";
        }
        public VeloMax(List<Velo> velo, List<Piece> piece, List<Commande> commande, List<Fournisseur> fournisseur,
            List<Client> client, List<Adresse> adresse, List<Programme> programme,
            List<Tuple<Velo, Piece, int>> liste_assemblage,
            List<Tuple<Commande, Piece, int>> liste_piece_commande,
            List<Tuple<Commande, Velo, int>> liste_velo_commande,
            List<Tuple<Piece, Fournisseur, int>> catalogue)
        {
            //Tables
            this.velo = velo;
            this.piece = piece;
            this.commande = commande;
            this.fournisseur = fournisseur;
            this.client = client;
            this.adresse = adresse;
            this.programme = programme;

            //Associations
            this.liste_assemblage = liste_assemblage;
            this.liste_piece_commande = liste_piece_commande;
            this.liste_velo_commande = liste_velo_commande;
            this.catalogue = catalogue;
        }
        #endregion Constructeurs

        #region Accesseurs Listes
        //Tables
        public List<Velo> Liste_velo
        {
            get { return velo; }
            set { velo = value; }
        }
        public List<Piece> Liste_piece
        {
            get { return piece; }
            set { piece = value; }
        }
        public List<Commande> Liste_commande
        {
            get { return commande; }
            set { commande = value; }
        }
        public List<Fournisseur> Liste_fournisseur
        {
            get { return fournisseur; }
            set { fournisseur = value; }
        }
        public List<Client> Liste_client
        {
            get { return client; }
            set { client = value; }
        }
        public List<Adresse> Liste_adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public List<Programme> Liste_programme
        {
            get { return programme; }
            set { programme = value; }
        }

        //Associations
        public List<Tuple<Velo, Piece, int>> Liste_assemblage
        {
            get { return liste_assemblage; }
            set { liste_assemblage = value; }
        }
        public List<Tuple<Commande, Piece, int>> Liste_piece_commande
        {
            get { return liste_piece_commande; }
            set { liste_piece_commande = value; }
        }
        public List<Tuple<Commande, Velo, int>> Liste_velo_commande
        {
            get { return liste_velo_commande; }
            set { liste_velo_commande = value; }
        }
        public List<Tuple<Piece, Fournisseur, int>> Catalogue
        {
            get { return catalogue; }
            set { catalogue = value; }
        }
        #endregion Accesseurs Listes     

        #region Accesseurs Requêtes
        public string GetVelo
        {
            get { return this.getVelo; }
        }
        public string GetPiece
        {
            get { return getPiece; }
        }
        public string GetCommande_entreprise
        {
            get { return getCommande_entreprise; }
        }
        public string GetCommande_particulier
        {
            get { return getCommande_particulier; }
        }
        public string GetFournisseur
        {
            get { return getFournisseur; }
        }
        public string GetClient_entreprise
        {
            get { return getClient_entreprise; }
        }
        public string GetClient_particulier
        {
            get { return getClient_particulier; }
        }
        #endregion Accesseurs Requêtes

        #region Gestion (velo, piece, client, fournisseur, commande)
        #region chaîne de caractère pour les queries
        public string Concatenate_Create(string table, string[] variables)
        {
            string conc = "INSERT INTO " + table + " VALUES (";
            for (int i = 0; i < variables.Length - 1; i++)
            {
                conc += variables[i] + ", ";
            }
            return conc + variables[variables.Length - 1] + ");";
        }
        public string Concatenate_Update(string table, string columnFind, string columnChange, string variableFind, string variableChange)
        {
            return "UPDATE " + table + " SET " + columnChange + "=" + variableChange +
                " WHERE " + columnFind + "=" + variableFind + ";";
        }
        public string Concatenate_Remove(string table, string column, string nameVariable)
        {
            return "DELETE FROM " + table +
                " WHERE " + column + " ='" + nameVariable + "';";
        }
        #endregion string des queries
        public void Query(MySqlConnection connection, string query)
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(" ErreurConnexion : " + e.ToString());
                Console.ReadLine();
                return;
            }
            connection.Close();
        }

        //Pensez à vérifier si les string entrés sont bons
        //à partir du Mainwindow WPF
        //==> format date - int - nombre de variables
        //voir si on ouvre la connexion dans Query

        /// <summary>
        /// Créer un tuple dans une table
        /// </summary>
        /// <param name="connection">connexion MySQL</param>
        /// <param name="table">nom de la table</param>
        /// <param name="variables">contient les variables à placer dans la requête SQL</param>
        /// <param name="indexNb">index des nombres qui sont des int ou bien des null</param>
        public void Create(MySqlConnection connection, string table, string[] variables, int[] indexNb)
        {
            for (int i = 0; i < variables.Length; i++)
            {
                //si la variable n'est pas un nombre
                if (!indexNb.Contains(i)) variables[i] = "'" + variables[i] + "'";             
            }
            Query(connection, Concatenate_Create(table, variables));
        }

        /// <summary>
        /// Supprime un élément de la BDD
        /// </summary>
        /// <param name="connection">connexion MySQL</param>
        /// <param name="table">nom de la table</param>
        /// <param name="column">nom de la colonne de la table</param>
        /// <param name="variable">variable correspondant au tuple à supprimer</param>
        /// <param name="variableIntOrNull">indique si la variable est int ou null
        /// pour adapter sa forme conséquence</param>
        public void Remove(MySqlConnection connection, string table, string column, string variable, bool variableIntOrNull)
        {
            if (!variableIntOrNull) variable = "'" + variable + "'";
            Query(connection, Concatenate_Remove(table, column, variable));
        }

        /// <summary>
        /// Met à jour la variable d'un élément
        /// </summary>
        /// <param name="connection">connexion MySQL</param>
        /// <param name="table">nom de la table</param>
        /// <param name="columnFind">nom de la colonne dans laquelle chercher</param>
        /// <param name="columnChange">nom de la colonne où le changemet est appliqué</param>
        /// <param name="variableFind">variable par laquelle le tuple à changer est identifié</param>
        /// <param name="variableChange">modification à appliquer</param>
        /// <param name="variableFindIntOrNull">variableFind true si elle est int ou null et false sinon</param>
        /// <param name="nvariableChangeIntOrNull">variableChange si elle est int ou null et false sinon</param>
        public void Update(MySqlConnection connection, string table, string columnFind, string columnChange, string variableFind, string variableChange, 
            bool variableFindIntOrNull, bool nvariableChangeIntOrNull)
        {
            if(!variableFindIntOrNull) variableFind = "'" + variableFind + "'";
            if (!nvariableChangeIntOrNull) variableChange = "'" + variableChange + "'";
            Query(connection, Concatenate_Update(table, columnFind, columnChange, variableFind, variableChange));
        }
        #endregion Gestion (velo, piece, client, fournisseur, commande)

        #region Module Statistiques

        #endregion Module Statistiques

        public DataTable dataLoader(MySqlConnection connection, string requete)
        {
            connection.Open();
            MySqlCommand commande = connection.CreateCommand();
            commande.CommandText = requete;
            MySqlDataReader reader = commande.ExecuteReader();

            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();

            connection.Close();
            return data;
        }
    }
}
