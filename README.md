[![GitHub release](https://img.shields.io/badge/Webpage-green.svg)](https://codingshadows.com/apps/driversdata/index.html)
[![GitHub release](https://img.shields.io/badge/Play_Store_Free-U1_P1306(20)_234-blue.svg)](https://play.google.com/store/apps/details?id=com.codingshadows.driversdata)
[![GitHub release](https://img.shields.io/badge/Play_Store_Paid-U1_P1306(20)_234-blue.svg)](https://play.google.com/store/apps/details?id=com.codingshadows.driversdata.paid)
[![GitHub release](https://img.shields.io/badge/Release-U1_P1306(20)_234-blue.svg)](https://github.com/CodingShadows/DriversDataAndroid/releases)
[![GitHub release](https://img.shields.io/badge/Tutorials_(Ro)-green.svg)](https://www.youtube.com/playlist?list=PLj7tWbLsoz2SCSQ0vRLAb_liu0gao1bcg)

# Drivers Data : Foaie de parcurs virtuală

# Pe unde a fost Drivers Data?

[![GitHub release](https://img.shields.io/badge/TV_Shows-ILikeIT_ProTV-blue.svg)](https://stirileprotv.ro/stiri/ilikeit/ilikeit-aplicatia-care-ajuta-soferii-sa-economiseasca-sute-de-ore-de-munca.html)

[![GitHub release](https://img.shields.io/badge/TV_Shows-ILikeIT_FHD_YouTube-red.svg)](https://www.youtube.com/watch?v=JqZnYIqbFLA)

[![GitHub release](https://img.shields.io/badge/Competitions-InfoEducatie_(Online_2020)-green.svg)](https://community.infoeducatie.ro/t/drivers-data-foaie-de-parcurs-virtuala-utilitar-bucuresti-lucrari-2020-online/5129)

# Materiale de prezentare Drivers Data.

[![GitHub release](https://img.shields.io/badge/Slides-blue.svg)](https://codingshadows.com/slides/drivers_data.html#slide=1)


# Ce este Drivers Data?

📜 Prima foaie de parcurs virtuala.

📜 Oriunde, oricând, la un singur clic.

📜 Stocați ușor metadate despre orice autovehicul folositi (mașina camion trenul) sau orice alt mijloc de transport.
Interfață ce poate fi complet personalizată de catre utilizator pentru a se potrivi cu exactitate nevoilor.
Verificați cu ușurință performanta dvs. și călătoria. 

📜 Calculează o varietate mare de date, precum: numărul de ore muncite, economia de combustibil, numărul de ore de aer condiționat și multe altele!

📜 Creează cu un singur click un tabel cu datele tale pentru orice perioada de timp! Poți să vezi datele pentru o singură zi, o luna sau chiar câțiva ani!


# Documentatia tehnica

Cerinte de sistem minime:  
•	Android 5.1+ (API 22+) (Lollipop+)  
•	Conexiune la internet: 5KB +  
•	Memorie ram: 250 MB+  
•	Memorie stocare: 15 MB+  
•	CPU: ARM Cortex-A53, 1300 MHz sau Snapdragon 630 sau echivalent  
•	OpenGL ES 2.0+  

Cerinte de sistem optime:  
•	Android 6.0+ (API 23+) (Marshmallow+)  
•	Conexiune la internet: 50KB+  
•	Memorie ram: 1GB+  
•	Memorie stocare: 30MB+  
•	CPU: Snapdragon 730 sau echivalent  
•	OpenGL ES 2.0+  

Permisiuni necesare:  (12 permisiuni)  
•	android.permission.ACCESS_COARSE_LOCATION  
•	android.permission.ACCESS_FINE_LOCATION  
•	android.permission.ACCESS_NETWORK_STATE  
•	android.permission.ACCESS_WIFI_STATE  
•	android.permission.CHANGE_WIFI_STATE  
•	android.permission.INTERNET  
•	android.permission.READ_EXTERNAL_STORAGE  
•	android.permission.RECEIVE_BOOT_COMPLETED  
•	android.permission.WAKE_LOCK  
•	android.permission.WRITE_EXTERNAL_STORAGE  
•	com.google.android.c2dm.permission.RECEIVE  
•	com.google.android.finsky.permission.BIND_GET_INSTALL_REFERRER_SERVICE  


Arhitectura:   
•	33 de fisiere ce contin cod Java (back-end)  
•	25 fisiere ce contin cod XML  


Tehnologii folosite:  
•	'com.google.android.play:core:1.6.4'  
•	'com.crashlytics.sdk.android:crashlytics:2.10.1'  
•	'com.google.firebase:firebase-perf:19.0.4'  
•	'com.google.firebase:firebase-core:17.2.1'  
•	'com.google.firebase:firebase-auth:19.2.0'  
•	'com.google.firebase:firebase-firestore:21.3.1'  
•	'com.google.firebase:firebase-functions:19.0.1'  
•	'com.google.firebase:firebase-storage:19.1.0'  
•	'androidx.appcompat:appcompat:1.1.0'  
•	'androidx.constraintlayout:constraintlayout:1.1.3'  
•	'com.google.android.gms:play-services-auth:17.0.0'  
•	'junit:junit:4.13'  
•	'androidx.test:runner:1.2.0'  
•	'androidx.test.espresso:espresso-core:3.2.0'  
•	'org.jetbrains:annotations-java5:15.0'  
•	'androidx.recyclerview:recyclerview:1.1.0'  
•	files('libs/poi-3.7.jar')  
•	'com.google.android.gms:play-services-ads:18.3.0'  
•	'com.google.android.material:material:1.0.0'  
•	'androidx.cardview:cardview:1.0.0'  
•	'com.google.android.libraries.places:places:2.1.0'  
•	'com.google.android.gms:play-services-maps:17.0.0'  
•	Trello  
•	GitHub  
•	Android Studio  
•	Adobe Illustrator  
•	Adobe Photoshop  


Suporta:  
•	Android 11 (API 30)(Android R)  
•	WebSockets  
•	OpenGL ES: 2.0+  
•	OpenGL texturi: toate texturile  
•	Native platforms: all native platforms  
•	Screen layouts: 4 screen layouts: small, normal, large, xlarge  
•	Tipuri de dispozitive suportate: 10221  

•	Activity_AddData:
-	Sumar clasa: Activitatea din care utilizatorul poate adauga date
-	onCreate(@Bundle): afiseaza interfata si initializeaza alte functii si elemente din interfata
-	initViewsBySettings(): se asigura ca setarile utilizatorului sunt indeplinite
-	initAD(): initializeaza adurile
-	onClick(View v): asigura functionalitatea butoanelor din UI
-	onFocusChange(View v, boolean hasFocus): asigura functionalitatea butoanelor din UI
-	checkFields(): verifica daca datele introduse de utilizator sunt valabile pentru adaugarea pe server
-	getData(): aduna datele adaugate de utilizator din elementele de UI 
-	checkData(): verifica daca datele introduse de utilizator sunt valabile pentru adaugarea pe server
-	getLastCustomNorm(): cauta in fisierele aplicatiei date introduse de utilizator in trecut, in legatura cu normarea speciala
-	processData(): pre-proceseaza datele introduse de utilizator
-	pushToServer(): adauga datele introduse de utilizator pe server
-	problemWithData(): in cazul in care apare o problema legata de datele introduse se apeleaza aceasta functie
-	cleanData(): pregateste clasa pentru un nou set de date
-	checkDoubleHours(String date): verifica daca ziua selectata de utilizator este elgibila pentru plata speciala
-	cleanDisplayData(): pregateste clasa pentru un nou set de date (UI)
-	getNormare(String linieGET): obtine normarea pentru linia introdusa de pe server
-	showCalendar(): arata calendarul pentru a selecta data pentru care se vor introduce datele
-	showSelectStartTime(): arata ceasul pentru a selecta ora de intrare
-	showSelectEndTime(): arata ceasul pentru a selecta ora de iesire
-	checkDigit(int number): returneaza numarul cu care este apelata functia dar cu un „0” inainte
-	implementDateListener(): asigura afisarea calendarului la cererea utilizatorului
-	formatDouble(Double number): verifica daca numarul este in formatul corespunzator
-	checkForPastKilometers(): verifica daca utilizatorul a mai introdus date in trecut legate de numarul de KM
-	savePastKilometers(): salveaza date legate de numarul de KM
-	checkForExistingData(String dayID): verifica daca exista deja date pentru ziua respectiva



•	Activity_CalculateRoute:
-	Sumar clasa: Calculeaza distanta dintre 2 locatii introduse de utilizator
-	setListenerForStartLocation(): afiseaza elementele de UI solicitate de utilizator 
-	setListenerForFinalLocation(): afiseaza elementele de UI solicitate de utilizator
-	calculateDistance(): calculeaza distanta dintre locatiile introduse
-	parseJson(String jsonFile): citeste date dintr-un fisier de tip JSON
-	calculateEstimatedNorm(): calculeaza normarea estimata pentru traseul selectat
-	getLastCustomNorm(): verifica pentru normari speciale introdse de utilizator in trecut
-	loadVideoAd(): incarca publicitatea 
-	showVideoAd(): afiseaza publicitatea

•	Activity_Contact:
-	Sumar clasa: Folosita de utilizator pentru a ma contacta
-	checkData(): verifica validitatea datelor
-	gatherData(): strange datele introduse de utilizator
-	sendData(final FirebaseFirestore database, int requestNumber): trimite datele pe server
-	startJob(): porneste un proces ce asteapta un raspuns de la server, cu raspunsul pentru cererea utilizatorului

•	Activity_DeleteData:
-	Sumar clasa: Folosita pentru a sterge datele de pe server
-	hideAllCards(): ascunde elemente de UI
-	showAllCards(): afiseaza elemente de UI
-	getData(String date): aduna datele de pe server pentru un preview
-	showData(String dataPacket): afiseaza datele (preview)
-	showCalendar(): afiseaza calendarul pentru selectia datei pentru care sunt sterse / cerute datele
-	deleteDocument(): sterge datele de pe server

•	Activity_EditProfile:
-	Sumar clasa: Folosita de utilizator pentru a edita datele din profil
-	getProfileInfo(): aduna datele utilizatorului de pe server
-	saveProfileInfo(): salveaza noile date ale utilizatorului

•	Activity_Login:
-	Sumar clasa: Autentifica utilizatorul daca este cazul, daca nu il trimite in ecranele corespunzatoare (inregistrare / recuperare a contului)
-	onCreate(@Bundle) afiseaza interfata si initializeaza alte functii si elemente din interfata
-	onRequestPermissionResult(@RequestCode, @Permissions[], @GrantResults[]): functia este apelata dupa ce utilizatorul accepta permisiunile cerute de aplicatie
-	checkStorage(): verifica daca aplicatia are permisiuni de citire/scriere
-	checkPrivacyPol(): verifica daca utlizatorul a acceptat Politica de Confidentialitate
-	readFileAsString(@fileName): citeste date dintr-un fisier

•	Activity_LoginHelper:  
-	Sumar clasa: Ghideaza utilizatorul catre inregistrare sau logare

•	Activity_Logout:  
-	Sumar clasa: Activitate afisata dupa ce utilizatorul este delogat

•	Activity_MainScreen:  
-	Sumar clasa: Ecranul principal al aplicatiei
-	changeLocale(): verifica preferintele utilizatorului in legatura cu limba in care este afisat textul aplicatiei
-	checkUpdateListener(): verifica daca utilizatorul doreste sa actualizeze aplicatia
-	showMenu(): arata meniul lateral
-	checkForUpdate(): verifica daca exista un update sugerat de server
-	checkForUpdateAutomatically(): verifica daca exista un update disponibil prin Google Play
-	getAnnouncements(): colecteaza anunturile ce trebuie afisate
-	displayAnnouncement(): daca exista, afiseaza anunturile

•	Activity_Menu:  
-	Sumar clasa: Meniul lateral al aplicatiei
-	initUI(): initializeaza interfata
-	logout(): delogheaza utilizatorul
-	alte functii corespunzatoare butoanelor din meniu

•	Activity_OtherAppsFromUs:  
-	Sumar clasa: Afiseaza alte aplicatii realizate de mine

•	Activity_PastTickets:
-	Sumar clasa: Afiseaza cererile anterioare ale utilizatorului
-	getCounter(): obtine de pe server numarul de cereri anterioare
-	getData(int position): obtine de pe server date referitoare la fiecare cerere anterioara
-	displayRequest(): afiseaza cererile anterioare

•	Activity_PrivacyPolicy:
-	Sumar clasa: Afiseaza Politica de Confidentialitate

•	Activity_Register:
-	Sumar clasa: Inregistrarea utilizatorului
-	initViews(): initializeaza elementele de UI
-	register(): inregistreaza utilizatorul

•	Activity_RequestResponse:
-	Sumar clasa: Afiseaza raspunsul primit in urma depunerii cererii
-	getDataFromServer(): aduna datele de pe server
-	showData(String requestBody, String responseBody): afiseaza datele
•	Activity_Settings:
-	Sumar clasa: Activitatea din care utilizatorul isi selecteaza preferintele cu privire la activitatile pe care aplicatia le desfasoara
-	setVatmanPreset(): activeaza presetul pentru vatmani
-	setMechanicPreset(): activeaza presetul pentru mecanic
-	setSoferPreset(): activeaza presetul pentru sofer
-	setHoursOnlyPreset(): activeaza presetul doar cu ore
-	setHoursAndLinePreset(): activeaza presetul doar cu ore si linie
-	saveSettings(): salveaza setarile introduse de utilizator


•	Activity_ShareTheApp:
-	Sumar clasa: Activitatea din care utilizatorul poate distribui aplicatia

•	Activity_ShowData:
-	Sumar clasa: Activitatea din care utilizatorul poate vedea datele introduse pentru o anumita zi din an
-	getData(String date): aduna datele legate de acea zi de pe server
-	showData(String dataPacket): afiseaza datele adunate de pe server
-	emptyAllFields(): pregateste interfata pentru o noua selectie a zilei

•	Activity_ShowDataOnInterval:
-	Sumar clasa: Activitatea din care utilizatorul poate vedea datele introduse pentru o orice perioada de zile din unul sau mai multi ani
-	saveTableSettings(): salveaza setarile selectate de utilizator pentru tabelul de Excel
-	getTableSettings(): citeste setarile introduse de utilizator in trecut pentru tabelul de Excel
-	setDefaultExcelSettings(): aplica setarile citite de functia de mai sus
-	showInterstitialAd(): afiseaza publicitatea
-	isValidDate(String input): verifica daca data pentru care se va face un query este valida
-	getFromServer(int day, int month, int year): obtine de pe server datele introduse pentru data respectiva
-	processData(String dataPacket): proceseaza datele obtinute de pe server
-	displayData(): afiseaza datele adunate
-	createCustomExcelTable(): creeaza tabelul de excel
-	sortDataVector(): sorteaza vectorul cu date
-	openExcelFile(): deschide tabelul de Excel creat

•	Activity_Splash:
-	Sumar clasa: Activitatea ce este afisata atunci cand se deschide aplicatia
-	checkStorage(): verifica daca aplicatia are permisiunile necesare
-	checkLogin(): verifica daca utilizatorul a mai fost autentificat inainte
-	getSettings(): citeste setarile utilizatorului



•	Activity_Tutorial:
-	Sumar clasa: Afiseaza un mic tutorial al aplicatiei  

•	Class_AppFilesManager  
•	Class_AppIntegrityChecker  
•	Class_AppVariables  
•	Class_CurvedBottomNavigationView  
•	Class_ManageLocale  
•	Class_ManageLogFile  
•	Job_CheckTicketResponse  

# Documentatia utilizatorului (manual de utilizare)

  Un manual de utilizare scurt poate fi gasit in aplicatie: apasati pe butonul din stanga sus, asftel se deschide meniul. Din meniu selectati butonul pe care scrie „Tutorial”. Glisati stanga/dreapta pentru a citi instructiunile. Apasati pe butonul din dreapta jos pe care scrie „Inchide”, pentru a inchide fereastra.

  Care este scopul aplicatiei? : Cu ajutorul acestei aplicatii, toti soferii, vatmanii si mecanicii de tren isi pot crea o foaie de parcurs virtuala, ce poate fi adaptata in functie de nevoile utilizatorului cu ajutorul setarilor.

  Utilizari de baza:   
•	Cum deschid meniul?: se apasa pe butonul cu 3 linii orizontale din partea stanga sus.  
•	Cum pot adauga date?: se deschide meniul, se apasa pe butonul „Adauga date”, se selecteaza ziua/data dorita si apoi se completeaza campurile dorite. Se apasa pe butonul „Adauga datele”.  
•	Cum pot sa vad datele pe care le-am adaugat?: se deschide meniul, se apasa pe butonul „Afiseaza datele” si apoi se selecteaza ziua dorita.  
•	Cum pot sa creez un tabel Exel?: se deschide meniul, se apasa pe butonul „Situatie lunara”, apoi se selecteaza 2 date calendaristice intre care se vor aduna datele introduse de utilizator.  


Precizari: 
1.	Toate specificatiile prezentate in acest document sunt valabile pentru versiunea U1_P1804(20) a aplicatiei.  
2.	Toate detaliile prezentate in acest document reprezinta date partiale legate de aplicatie (documentatia tehnica), din motive de securitate.  
3.	Toate detaliile in legatura cu aplicatia prezentate in acest document reprezinta proprietatea CodingShadows (Rusu Dinu-Stefan).
4.	Aplicatia descrisa in acest document reprezinta in integralitate proprietatea intelectuala a CodingShadows (Rusu Dinu-Stefan).   
5.	Punctele 3. si 4. sunt descrise pe larg in documentul intitulat „Proprietary License”, anexat acestui document si se refera si la fragmentele de cod sursa atasate.  
6.	Aplicatia descrisa in acest document a fost realizata in integralitate de Rusu Dinu-Stefan, fondator al CodingShadows.  
7.	Date de contact:  
•	+(40)(756)(478)(663)  
•	dinu@codingshadows.com  
•	contact@codingshadows.com  
•	Facebook: @codingshadows  
•	https://codingshadows.com  



