 using AbstraindoCelular.Models;

 Nokia nokia = new Nokia("98569698", "Nokia M16", "2155245588",128);

 Iphone iphone = new Iphone("89856985", "Iphone 12", "12525632", 256);
 
 iphone.DescricaoTelefone("Iphone");
 iphone.ReceberLigacao();
 iphone.ligar();
 iphone.InstalarAplicativo("WhatsApp");

 nokia.DescricaoTelefone("Nokia");
 nokia.ReceberLigacao();
 nokia.ligar();
 nokia.InstalarAplicativo("Instagram");
