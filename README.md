# LateAtClass

## Tutoriel pour repartir de 0

1) Récupérer le projet vierge
- Téléchargez le package https://connect-prd-cdn.unity.com/20210402/8a67971c-e957-4844-9964-8445a85103e8/Create-with-VR_2020LTS.zip?_ga=2.128504012.1795054087.1639555843-1656829093.1639409693
- Récupérez et décompressez le package
- Vous pouvez renommer le projet
- Ajoutez le comme un nouveau projet dans le Unity Hub
- Ouvrez le projet via Unity Hub
(Etapes provenant du site https://learn.unity.com/course/create-with-vr?uv=2020.3 )

2) Installer le PICO SDK pour développer sur Unity
Documentation du PICO : https://sdk.picovr.com/docs/UnityXRSDK/en/index.html
- Téléchargez le SDK : https://developer.pico-interactive.com/sdk => Device : G2 4k Series => Download (Pico XR_Platform_SDK-1.2.5_B81)
- Décompressez l'archive
- Sur Unity : Importez le SDK par le menu Windows > Package Manager > +>Add package from disk. Sélectionnez le fichier package.json
- Il est possible qu'une fenêtre PXR SDK setting s’ouvre. Dans ce cas, décochez le User Entitlement Check mais laissez les autres paramètres par défaut (dont l’orientation de l’appli).
- Edit > Project Settings > XR Plug-in Management. Cliquez sur l'onglet Android puis cochez la case « PicoXR »
A ce stade la librairie PICO est installée sur votre projet Unity. Vous devriez voir un nouveau menu « PXR_SDK » dans la barre de tâche Unity. De plus, dans la fenêtre Project de Unity, le dossier Assets contient maintenant un dossier « XR » ou « PICOXR plugin ».

3) Mettre API level à jour
- Sur Unity : Edit > Project settings > Player. Cliquez sur l'onglet Android > Other Settings > Identification > Minimum API Level > Android 8.0 'Oreo' (API level 26)

4) Tester le projet
- Sur Unity : File > Build Settings > Add Open Scenes. Sélectionnez la scène "Scenes/Create_with_VR_Starter_Scene"
- Choisissez la plateforme Android > Switch Platform puis :
	- Build en tant qu'apk
	- Ajouter l'apk dans le pico : G2 4K S\Internal shared storage\Download
	OU
	- Sélectionnez le Pico dans Run device puis Build And Run

## Exporter le projet en tant que package (.unitypackage) :
Sur Unity : Assets > Export package > All

## Importer le projet en tant que package (.unitypackage) :
Sur Unity : Assets > Import package > Custom package