# Siguri_Projektet

Projekti_1: Enkriptimi dhe dekriptimi përmes Playfair Cipher në Java.

Njëri ndër algoritmet kriptografike me të njohura shumë-shkronjëshe është Playfair.
Principi i punës së këtij algoritmi bazohet në matricën 5x5 në të cilën janë vendosur
shkronjat e alfabetit, e cila konstruktohet sipas një celesi (angl. Key).

Matrica konstruktohet sipas rregulles: së pari vendosen shkronjat e fjalës celës (minus shkronjat e dyfishuara) nga e majta në të djathtë dhe nga lart poshtë, pastaj pjesa tjetër mbushet me shkronja e mbetura të alfabetit sipas radhës së tyre. Shkronja I dhe J numerohen si një shkronjë.

Enkriptimi shkon sipas procesit ne vijim:

Fillimisht largohen të gjithë karakteret që nuk gjenden në matricën e celësit, pastaj ndahet teksti për enkriptimi në grupe me nga 2 karaktere. Nëse karakteret janë të njëjta atëherë karakteri i dytë zevendësohet me shkonjën X. Nëse numri i karaktereve është tek atëherë i shtohet në fund shkronja X. Pasi që ndahet në karaktere, kontrollohet pozita e secilit grupacion dhe bëhet enkriptimi sipas rregullave në vijim:
Nëse gjinden në rreshta të njëjtë atëherë merret elementi pasues; nëse është në kolonën e fundit atëherë merret elementi i parë.
Nëse gjinden në kolona të njejta atëherë merret elementi i rreshtit pasues por i kolonës së njëjtë; nëse është në rreshtin e fundit atëherë merret elementi i rreshtit të parë të kolonës së njëjtë.
Nëse gjinden në rreshta dhe kolona të ndryshme atëherë merret elementi i rreshtit të njëjtë por i kolonës së karakterit/shkronjës tjetër.

Projekti_2: Komunikimi klient-server në gjuhën programuese C#.

Protokolli: TCP
Baza e shënimeve: JSON
Celësi publik: XML
Nënshkrimi: JWT

Projekti_3: Emaili i enkriptuar dhe i nënshkruar në form digjitale.
