# Introduction:

Je suis étudiant à la SAE institute de Genève, et comme premier module, nous devions créer un jeu simple en 2D avec de la physique.
J'ai décidé d'utiliser le moteur de jeu Unity pour créer un Platformer 2d simple nommé Super (Not) Mario Bros.
Au départ, je voulais faire un jeu avec beaucoup de niveaux, de mondes et de monstres, puis je me suis rendu compte que j'étais beaucoup ambitieux sur tout ça.

J'ai donc fait l'essentiel.

# Scénario:

![](https://github.com/LudoBernard/Super-Not-Mario-Bros./blob/gh-pages/Game.png)

L'histoire du jeu est plutôt simple, vous jouez (Not) Mario, un personnage très original et non inspiré d'un autre jeu vidéo, qui vivait paisiblement dans sa petite maison, au fond d'une forêt, quand soudainement, une porte mystérieuse apparait hors de nul part. Il décide donc d'aller voir cette fameuse porte, mais pour cela, il doit d'abord trouver la clé qui s'est cachée dans la forêt.

# Gameplay et fonctionalités:

Le jeu contient un système de mouvement très simple. Les touches A et D, ou les flèches directionelles permettent au joueur de se déplacer à gauche ou à droite. La barre espace permet au joueur de sauter, et le bouton Escape met le jeu en pause.
Le déplacement est également compatible avec la manette.
Il y a également des gemmes qui flottent et qui augmentent le score du joueur dès qu'elle sont récupérées.
De plus, l'environement est hostile, en effet, le niveau contient des piques, de l'eau, ainsi que des zombies qui font perdre de la vie au joueur.
Le menu principal ainsi que le menu pause ont des menu options qui permettent au joueur de changer le son de la musique ou des effets sonores du jeu.
Pour gagner, il suffit de trouver la clé et d'ouvrir la porte.

# Ce que j'ai appris / réussi à faire:

- Le langage C#
- Utiliser le moteur Unity plus facilement et rapidement
- Créer et utiliser de l'UI (menus, score, points de vie...)
- Gérer et implémenter du son grace à Fmod Studio, ainsi: que modifier le volume en jeu.
- Mieux gérer mes scripts, mieux coder.
- Trier les assets dans un fichier spécifique à chacun.
- Animer des personnages / objets et les afficher à l'écran.
- Faire un jeu complet sur Unity!

# Contraintes / Problèmes / Ce que je n'ai pas réussi à faire:

Même si le jeu à l'air très complet et contient beaucoup de fonctionalités dont je suis fier, il y a cependant beaucoup de choses qui ont ralenti, voir bloqué mon progrès à certains moment du développement:

## Le mouvement sur le sol:
   
   Mon personnage, ainsi que les Zombies, se bloquaient de temps en temps dans la tilemap du sol, ce qui les empêchait de bouger. Après plusieurs essais de correction, la seule solution qui fonctionnait réellement était de mettre des Capsule Collider 2D aux personnages, au lieu de mettre des Box Collider 2D, ceci règla instantanément le problème.
   
## L'UI, les menus, et les boutons:
   
   Vu mon niveau de débutant sur Unity, je ne savais pas comment créer une interface utilisateur (UI) pour afficher un score, de la vie, ou pour créer un menu avec des boutons.
   Grace à des tutoriels que j'ai regardé plusieurs fois jusqu'à ce que je comprenne, j'ai réussi à implémenter tout ce que je voulais faire, le menu principal, un menu option, ainsi qu'un menu pause, avec tous les boutons fonctionnels.
   
## Le son:
   
   Implémenter et gérer le son n'était pas la partie la plus dure, en effet, pour ajouter un nouveau son, cela me prenait moins d'une minute.
   Le vrai problème était le ***volume***.
   Encore une fois, grace à des tutoriels, j'ai pu me débrouiller et créer des options pour gérer le volume de la musique, et des effets sonores.
   
## Le confinement, un manque de motivation:
   
   Avec le confinement, le temps que j'avais pour travailler sur le jeu s'est multiplié par 10, cependant ma motivation s'est divisée par 10. L'isolement, le manque d'air frais, ce nouveau mode de vie à beaucoup influé sur mon mental et ma capacité à me concentrer, et à vouloir travailler. J'ai bien sûr réussi à surmonter cela en y allant petit à petit, jusqu'à ce que le jeu prenne doucement forme.
   
## Git:
   
   J'ai eu beaucoup de moments de confusion avec Git: des erreurs fréquentes inexpliquées, des problèmes de fichiers, ne pas savoir comment supprimer un fichier du répertoire, ou bien comment changer le fichier .gitignore.
   Mon savoir sur Git reste très flou, mais j'arrive cependant à l'utiliser à des fins simples telles que ce jeu.
   
## L'implémentation console:
   
   La partie la plus compliquée de tout ce projet, est l'implémentation de la console pour le jeu.
   Je n'ai pas réussi à utiliser InControl comme demandé. Après plusieurs malheureux essais confus avec InControl, j'ai décidé d'abandoner pour une alternative qui ne fonctionne    que pour les déplacement et le saut: L'Input Manager de Unity.
   L'Input Manager m'a permis de choisir les touches que je voulais utiliser pour les axes, pour le saut, et autres commandes.
   
# Conclusion:

Ce projet m'a appris énormément de choses sur Unity, le C# ainsi que la création d'un jeu en général.
Malgré l'angoisse, la frustration, et la colère des bug, des erreurs ou des échecs, la réussite de ce projet (car pour moi, c'est une réussite) suscite des émotions positives bien plus fortes que celles éprouvées lors du développement.
Le création de ce jeu m'a aussi servi de leçon de vie: qu'il ne faut jamais baisser les bras, surtout au premier obstacle.
