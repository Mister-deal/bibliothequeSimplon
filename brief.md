Contexte du projet

Vous travaillez en tant que développeur backend dans une start-up technologique spécialisée dans la gestion numérique des bibliothèques. Le client, BibliothèqueSimplon, souhaite digitaliser la gestion de sa bibliothèque. Actuellement, les emprunts de livres et les informations des membres sont gérés de manière manuelle, ce qui entraîne des erreurs et une gestion lente des livres.

Votre mission consiste à concevoir une API REST permettant de simplifier et automatiser la gestion des livres, des emprunts et des membres d'une bibliothèque, tout en offrant une gestion sécurisée des employés via un système d'authentification par token JWT.
Modalités pédagogiques

Fonctionnalités Obligatoires:

​

1

 - Gestion des livres :

Créer des endpoints pour ajouter, modifier, supprimer et consulter les livres.

Chaque livre doit inclure les informations suivantes : Titre, Auteur, ISBN, Disponibilité.

L'API doit permettre de vérifier la disponibilité d'un livre pour un emprunt.

​

1

 - Gestion des membres :

Créer des endpoints pour ajouter, modifier, supprimer et consulter les membres.

Chaque membre doit inclure les informations suivantes : Nom, Prénom, Email.

(Bonus) Chaque membre peut consulter son historique.

​

1

- Gestion des emprunts :

Créer des endpoints permettant à un membre d’emprunter des livres.

L'emprunt doit enregistrer les livres empruntés, la date d’emprunt et la date de retour prévue.

Le système doit vérifier la disponibilité des livres avant un emprunt.

Les employés doivent pouvoir consulter les emprunts en cours et l'historique des emprunts par membre.

​

1

- Système d'authentification et gestion des employés :

Créer des endpoints permettant à un employé de se connecter via un token JWT.

L'API doit générer un token JWT à chaque connexion avec des informations d'authentification (email et mot de passe).

Les employés doivent avoir des rôles pour définir leurs permissions (par exemple, un administrateur pourra tout gérer, tandis qu’un bibliothécaire pourra gérer uniquement les livres et les emprunts).

​

Bonus

    Améliorations de l'authentification et gestion des rôles : Implémenter un système de gestion de rôles pour les employés de la bibliothèque (par exemple, un employé peut être bibliothécaire ou administrateur avec des permissions différentes). Ajouter la possibilité pour les employés de réinitialiser leur mot de passe avec un système d'email de récupération.
    Interface Front-End : Créer une interface utilisateur simple permettant aux employés de gérer les livres, les membres, les emprunts et de consulter l’historique des emprunts. L’interface doit utiliser les endpoints de l’API REST pour effectuer des actions et afficher des données.

Modalités d'évaluation
Exigences Techniques

- Utilisation du modèle MVC : Organisez le code avec le modèle MVC (Modèles pour les entités, Contrôleurs pour la gestion des requêtes, Services pour la logique métier, et Vues pour l'affichage des données).
- Injection de dépendances : Liez les contrôleurs aux services nécessaires via l’injection de dépendances (par exemple, un service pour gérer les livres ou les emprunts).
- DTOs (Data Transfer Objects) : Utilisez des DTOs pour séparer les données envoyées par l’API des données utilisées dans la logique métier (encapsulation des données).
- Entity Framework Core : Utilisez Entity Framework Core pour gérer la persistance des données dans une base de données relationnelle (livres, membres, emprunts).
- Authentification JWT : Implémentez un système d’authentification basé sur JWT pour sécuriser les endpoints nécessitant un accès restreint (par exemple, gestion des livres, des emprunts, etc.).

Présentation du projet
15 minutes le 01 Août 2025
Livrables
La solution dans un Repo Github.
Documentation:
- README.md : Inclure une documentation complète du projet, comprenant les étapes d'installation, de configuration et d’utilisation de l’API.
- Swagger : Documenter les endpoints de l’API à l’aide de Swagger pour permettre aux utilisateurs de tester facilement les fonctionnalités de l’API.
Critères de performance
Fonctionnalités : Respect des fonctionnalités décrites dans l'énoncé (gestion des livres, des membres, des emprunts, et authentification des employés).
Qualité du code : Code bien structuré, respect des bonnes pratiques (architecture MVC, utilisation d’injection de dépendances, séparation des préoccupations).
Utilisation d’Entity Framework : Bonne gestion des entités et des relations via Entity Framework Core.
Sécurisation de l’API : Mise en place correcte de l'authentification JWT et gestion des rôles des employés.
Documentation : Documentation claire et détaillée, avec des exemples d'utilisation de l’API.
Bonus : Système de gestion des rôles d’employés et interface front-end fonctionnelle.
