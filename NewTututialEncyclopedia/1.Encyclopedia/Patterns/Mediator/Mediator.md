W C# wzorzec projektowy mediator jest u¿ywany do organizowania komunikacji pomiêdzy obiektami, aby zmniejszyæ bezpoœrednie powi¹zania pomiêdzy nimi i zwiêkszyæ ich odseparowanie oraz przejrzystoœæ kodu. 

Mediator jest wzorcem behawioralnym, który pozwala na zast¹pienie wielu bezpoœrednich powi¹zañ pomiêdzy obiektami jednym obiektem mediatora. G³ówne cele u¿ycia mediatory to:

1. **Redukcja bezpoœrednich powi¹zañ**: Zamiast ka¿dy obiekt komunikowaæ siê bezpoœrednio z innymi obiektami, komunikacja odbywa siê za poœrednictwem mediatora.
   
2. **Zwiêkszenie przejrzystoœci**: Kiedy obiekty nie musz¹ bezpoœrednio siê odwo³ywaæ do siebie, kod staje siê bardziej przejrzysty, ³atwiejszy do zrozumienia i zarz¹dzania.

3. **U³atwienie rozszerzalnoœci**: Mediator mo¿e kontrolowaæ, jakie rodzaje komunikacji s¹ dozwolone miêdzy obiektami, co u³atwia wprowadzanie zmian i dodawanie nowych funkcjonalnoœci.

Typowe zastosowania wzorca mediatora w C# obejmuj¹ implementacjê GUI (interfejsu u¿ytkownika), gdzie ró¿ne elementy interfejsu mog¹ komunikowaæ siê poprzez mediatora, oraz w systemach zarz¹dzania zdarzeniami, gdzie mediator koordynuje reakcje na ró¿ne zdarzenia systemowe.

W implementacji wzorca mediatora w C#, zazwyczaj tworzy siê interfejs lub klasê mediatora, która definiuje metody komunikacji miêdzy obiektami. Obiekty te wiedz¹ tylko o mediatorze i u¿ywaj¹ go do komunikacji z innymi obiektami, nie wiedz¹c bezpoœrednio o tych obiektach.