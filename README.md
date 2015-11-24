#Dossier de préconception du MyoArm
<center>Cette application de simulation de bras et de main humaine est développée en partenariat avec une équipe du CHU de Nantes. Elle souhaite avoir à disposition une application permettant de soigner le syndrome du membre fantôme en pilotant un corps virtuel à l’aide d’électroencéphalographie et d’électromyographie.

<center>
<img src="http://fr.cdn.v5.futura-sciences.com/builds/images/rte/RTEmagicC_myoarm.jpg" height=150 /> + <img src="https://scontent.cdninstagram.com/hphotos-xap1/t51.2885-15/s320x320/e35/12230863_845228932242883_1474465373_n.jpg" height=150 /> + <img src="http://actualitesjeuxvideo.fr/wp-content/uploads/2013/03/casque-EEG.jpg" height=150 />

##Description de l’application
###Objectifs de l’application:
>0. **Traitement du syndrome du membre fantôme** (Objectif principal)
0. Rééducation physique des patients ayant subit une intervention ou un traumatisme de leur bras

###Objectifs à réaliser par l’utilisateur:
0. Bouger son bras naturellement (épaule + avant bras)
0. Bouger ses mains naturellement (poignets + doigts)
0. Attraper des objets de différentes formes
0. Suivre des mouvements pré-enregistrés
1. Voir son bras se déplacer de manière fluide

##Primitives comportementales virtuelles
**Observer** <img src="http://www.marieclaire.fr/data/fichiers/maquillage-yeux-2.jpg" height=50 />

L’utilisateur devra être capable de voir son propre corps, en particulier ses bras et ses mains. Des objets avec lesquels interagir, comme des objets à saisir ou des obstacles, devront aussi être visibles.

**Mouvoir son corps virtuel** <img src="http://previewcf.turbosquid.com/Preview/2014/05/24__00_55_57/armrenderindirect%20copy.jpg0c437ed6-b83b-4b52-a912-cd4a07aee320Larger.jpg" height=50 />

L’utilisateur pourra au moins déplacer ses bras, épaule incluse, et sa tête dans le monde virtuel.

**Saisir des objets** <img src="http://previewcf.turbosquid.com/Preview/2014/05/26__09_07_36/Hand_Primary.jpga9944262-3e2a-4208-916e-2853f4d1102cLarger.jpg" height=50 />

Une tâche courante réalisée avec les bras est la saisie d’objets. L’utilisateur devra donc tenter de saisir et déplacer des objets de formes différentes, ce qui nécessitera des mouvements de préhension différents. L’accessibilité des objets sera modifiée par des obstacles.

**Suivre un mouvement enregistré** <img src="http://fe867b.medialib.glogster.com/media/0c/0c62b012aac10b1cb0d1268317fd6d883205eff7af1d83bf3ec58ef5c2fa8529/follow-us.gif" height=50 />

L’utilisateur pourra être amené à suivre un mouvement enregistré représenté sous la forme d’un bras transparent.

**Agir** <img src="http://i1.wp.com/www.laoujetemmenerai.net/wp-content/2014/06/bonhomme_puzzle1.jpg" height=50 />

L’utilisateur pourra bouger ses bras de manière naturelle, les mouvements seront gérés par plusieurs centrales inertielles pour récupérer des points orientés dans l’espace et de capteurs EMG pour connaître le mouvement les doigts et l'intensité de la force appliquée.
Il pourra donc agir sur l’environnement directement en contrôlant un avatar virtuel à l’aide de ces capteurs.

**Communiquer** <img src="http://rosny.pcf.fr/sites/default/files/imagecache/image/46454_bonhomme_appel.jpg" height=50 />

L’utilisateur pourra interagir avec l’interface de l’application. De plus elle enregistrera ses commentaires et réaction pour analyse ultérieure.



##Solution d’interfaçage
**Casque de réalité virtuel** <img src="http://www.vrheadsets3d.com/wp-content/uploads/2014/10/Oculus-Rift-DK2.jpg" height=50 />

*Avantages:* Immerger totalement l’utilisateur dans le monde virtuel, capter les mouvements de la tête, interfacage simple avec Unity à l’aide de Middle VR

*Limitations:* Champ de vision faible, besoin d’un ordinateur+câble pour l’utiliser.

**Centrales inertielles** <img src="http://www.x-io.co.uk/wordpress/wp-content/uploads/2014/03/x-IMU-Board-Isometric.jpg" height=50 />

*Avantages:* Permet de capter un point dans l’espace et l’orientation, très précis et réactif, le magnétomètre assure qu’il n’y ait pas de dérive des mesures

*Limitations:* N’est pas compatible avec Middle VR donc il sera nécessaire de réaliser un script de traitement des mesures.

**Capteur EMG** <img src="http://www.robotshop.com/media/files/images2/seeedstudio-grove-emg-detector-5-large.jpg" height=50 />

*Avantages:* Capteur de surface, permet la reconnaissance des mouvements de la main, des doigts et du poignet. Utilisation probable d’un capteur Myo facile à placer sur l’avant bras de l’utilisateur.

*Limitations:* Nécessite une phase de calibration importante pour pouvoir détecter de manière correcte les mouvements.

**Capteur EEG** <img src="http://img.medicalexpo.fr/images_me/photo-m2/casque-electroencephalographie-128-canaux-67901-98853.jpg" height=50 />

*Avantages:* Permet d'identifier les intentions de bouger la main ou le bras, même si le membre est manquant.

*Limitations:* Complexité des signaux, et difficulté de traitement. Signaux peuvent être différents selon les individus.

**Myo band** <img src="https://hackwestern.com/img/showcase/myo.png" height=50 />

Un bracelet doté d'une centrale inertielle, d'un gyroscope et de huit électrodes EMG. Le bracelet peut être placé sur le bras ou l'avant bras.

*Avantages:* Possède un sdk ce qui simplifiera l'étude des signaux.

*Limitations:* L'utilisateur doit avoir un bras sur lequel viendra se positionner le capteur. Ce capteur ne pourra pas s'utiliser sur les patients ayant perdu leur membre.


##Les aides logiciels comportementales

**Affichage de missions à réaliser.** L’interface de l’application affiche les consignes à réaliser ainsi que d’éventuelles étapes intermédiaires.

**Aide pour attraper les objets :** ils collent à ses doigts lorsqu’il approche sa main. Ainsi cela facilitera la préhension. Cependant cette aide ne doit pas être trop importante pour que l’utilisateur soit obligé de réaliser un mouvement complet pour attraper l’objet.

**Aide pour poser les objets :** ils collent au support. Cela évitera des bug d’affichage et rendra le monde plus cohérent et immersif.

**Mouvements réalistes:** L’avatar ne peut pas se retourner le bras, certain degrés de libertés sont bloqués pour un rendu plus réaliste et pour éviter de choquer le patient.

>Il est nécessaire que la reproduction des mouvements soit réaliste pour que l’utilisateur identifie le bras de l’avatar comme étant son propre bras.



##Critères d’évaluations des I2 sensorimotrices, fonctionnelles et cognitives			
**→ Est­ ce qu’un geste correct est bien considéré comme bon par le simulateur?**
Précision des positions des mains et des gestes de l’opérateur, marges d’erreur sur ces positions. Différences entre le bras fantôme et le bras de l’avatar.
						
**→ Avez vous réussi à manipuler des objets ?**
Latence visuelle, précision de la détection des positions, clarté des instructions orales, utilité des ALC.

**→ Avez vous améliorer vos compétences en manipulation avec ce simulateur ?**
Efficacité des méthodes utilisées pour la rééducation
						
**→ De quelles manipulations vous souvenez vous ?**
Complexité des manipulations, possibilités d’apprentissage, justesse de la simulation.
						
**→ L’immersion est ­elle bonne ? Avez vous retrouvé les mêmes sensations qu’en vrai?**
Synchronisation et latence de la simulation par rapport aux mouvements du patient, crédibilité du monde virtuelle (3D réaliste, objets existants..)
					
				
			
		

 
