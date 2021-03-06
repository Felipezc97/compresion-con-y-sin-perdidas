clear all
clc
%Se selecciona una imagen de tamaño 512 x 512 pixeles
%Imagenes disponibles: 
% 'casa.png'-'chica.png' - 'chica2.png' - 'paisaje.png' - 'pikachu.png'
ImagenOPT=imread('chica2.png');
%La imagen se convierte a escala de grises
Imagen = rgb2gray(ImagenOPT);
% Filas del bloque
BloqueFila = 8; 
% Columna del bloque
BloqueColumna = 8; 

%Parámetros para poder partir la imagen original en secciones de 8x8
FilaBloqueEntero = floor(512 / BloqueFila);
BloqueVectorFila = [BloqueFila * ones(1, FilaBloqueEntero), rem(512, BloqueFila)];
ColumnaBloqueEntero = floor(512 / BloqueColumna);
BloqueVectorColumna = [BloqueColumna * ones(1, ColumnaBloqueEntero), rem(512, BloqueColumna)];

%Creacion de un array de celdas para almacenar los bloques
BloquesPartidos = mat2cell(Imagen, BloqueVectorFila, BloqueVectorColumna);

indice = 1;
forFilas = size(BloquesPartidos, 1);
forColumnas = size(BloquesPartidos, 2);
%Cada bloque es analizado
for f = 1 : forFilas-1
    for c = 1 : forColumnas-1
        %Se resta 128 a cada elemento de los bloques
        Bloque128{f,c}=int16(BloquesPartidos{f,c})-int16(128);
        %Transformada de coseno discreta de cada bloque 8x8
        TransformadaDCT{f,c}=round(dct2(Bloque128{f,c}));
        indice = indice + 1;
    end
end

%Presentar la imagen del nuevo dominio
BloqueUNOdespuesDCT=cell2mat(TransformadaDCT);

%Matriz de cuantización
MatCuant=[16 11 10 16 24 40 51 61   
          12 12 14 19 26 58 60 55
          14 13 16 24 40 57 69 56
          14 17 22 29 51 87 80 62
          18 22 37 56 68 109 103 77
          24 35 55 64 81 104 113 92
          49 64 78 87 103 121 120 101
          72 92 95 98 112 100 103 99];
      
%cuantizacion {5, 10, 20, 30, 50, 70 y 80}
%division de la matriz de cuantización por el factor Q
%division de la matriz transformada con DCT para la matriz cuantizada
%Adicion de 128 a cada nuevo bloque
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% // qf yo elijo
% // MatCuant MAtriz de cuantizacion MatCuant
% // MatCuantEscalada is the scaled Quantization Matrix
% // Q1 is a Quantization Matrix which is all 1’s
% if qf >= 50
% scaling_factor = (100-qf)/50;
% else
% scaling_factor = (50/qf);
% end
% if scaling_factor != 0 // if qf is not 100
% MatCuantEscalada = round( MatCuant*scaling_factor );
% else
% MatCuantEscalada = Q1; // no quantization
% end
% MatCuantEscalada = uint8(MatCuantEscalada); // max is clamped to 255 for qf=1
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

for f = 1 : forFilas-1
    for c = 1 : forColumnas-1
        %Q=5
        FacQ5{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*10));
        aux5{f,c}=FacQ5{f,c}.*MatCuant;
        FacQ5128{f,c}=round(idct2(aux5{f,c})+128);
        %Q=10
        FacQ10{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*5));
        aux10{f,c}=FacQ10{f,c}.*MatCuant;
        FacQ10128{f,c}=round(idct2(aux10{f,c})+128);
        %Q=20
        FacQ20{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*2.5));
        aux20{f,c}=FacQ20{f,c}.*MatCuant;
        FacQ20128{f,c}=round(idct2(aux20{f,c})+128);
        %Q=30
        FacQ30{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*(5/3)));
        aux30{f,c}=FacQ30{f,c}.*MatCuant;
        FacQ30128{f,c}=round(idct2(aux30{f,c})+128);
        %Q=50
        FacQ50{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*1));
        aux50{f,c}=FacQ50{f,c}.*MatCuant;
        FacQ50128{f,c}=round(idct2(aux50{f,c})+128);
        %Q=70
        FacQ70{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*(3/5)));
        aux70{f,c}=FacQ70{f,c}.*MatCuant;
        FacQ70128{f,c}=round(idct2(aux70{f,c})+128);
        %Q=80
        FacQ80{f,c}=round(TransformadaDCT{f,c}./round(MatCuant*(2/5)));
        aux80{f,c}=FacQ80{f,c}.*MatCuant;
        FacQ80128{f,c}=round(idct2(aux80{f,c})+128);
        %Q=100
        FacQ100{f,c}=round(TransformadaDCT{f,c});
        aux100{f,c}=FacQ100{f,c};
        FacQ100128{f,c}=round(idct2(aux100{f,c})+128);
    end
end
%Construccion de las imagenes a partir de la matriz de celdas 
ImagenFQ5=cell2mat(FacQ5128);
ImagenFQ10=cell2mat(FacQ10128);
ImagenFQ20=cell2mat(FacQ20128);
ImagenFQ30=cell2mat(FacQ30128);
ImagenFQ50=cell2mat(FacQ50128);
ImagenFQ70=cell2mat(FacQ70128);
ImagenFQ80=cell2mat(FacQ80128);
ImagenFQ100=cell2mat(FacQ100128);

%Primera ventana con imágenes
figure(1)
%Imagen Original
subplot(2,2,1), imshow(ImagenOPT),title('Original')
%Imagen en escala de grises
subplot(2,2,2), imshow(Imagen),title('Escala de Grises')
%Imagen despues de la transformada de coseno discreta
subplot(2,2,3), imshow(BloqueUNOdespuesDCT),title('Despues del DCT')
%Transformada inversa con Factor Q=50
subplot(2,2,4), imshow(uint8(ImagenFQ50)),title('Transformada inversa Qf=50')

%Segunda ventana con imágenes
figure('units','normalized','outerposition',[0 0 1 1])
%Imagen con Q=5
subplot(2,4,1), imshow(uint8(ImagenFQ5)),title('Factor Qf=5')
%Imagen con Q=10
subplot(2,4,2), imshow(uint8(ImagenFQ10)),title('Factor Qf=10')
%Imagen con Q=20
subplot(2,4,3), imshow(uint8(ImagenFQ20)),title('Factor Qf=20')
%Imagen con Q=30
subplot(2,4,4), imshow(uint8(ImagenFQ30)),title('Factor Qf=30')
%Imagen con Q=50
subplot(2,4,5), imshow(uint8(ImagenFQ50)),title('Factor Qf=50')
%Imagen con Q=70
subplot(2,4,6), imshow(uint8(ImagenFQ70)),title('Factor Qf=70')
%Imagen con Q=80
subplot(2,4,7), imshow(uint8(ImagenFQ80)),title('Factor Qf=80')
%Imagen con Q=100
subplot(2,4,8), imshow(uint8(ImagenFQ100)),title('Factor Qf=100')

%Calculo del error cuadratico (MSE) para cada imagen
err5 = immse(Imagen,uint8(ImagenFQ5));
err10 = immse(Imagen,uint8(ImagenFQ10));
err20 = immse(Imagen,uint8(ImagenFQ20));
err30 = immse(Imagen,uint8(ImagenFQ30));
err50 = immse(Imagen,uint8(ImagenFQ50));
err70 = immse(Imagen,uint8(ImagenFQ70));
err80 = immse(Imagen,uint8(ImagenFQ80));
err100 = immse(Imagen,uint8(ImagenFQ100));

%Gráfico de los errores
X=[5 10 20 30 50 70 80 100];
Y=[err5 err10 err20 err30 err50 err70/100 err80/1000 err100];
figure(3)
plot(X,Y,'-mo','LineWidth',2,'MarkerEdgeColor','k','MarkerFaceColor',[.49 1 .63],'MarkerSize',10);
str = {err5,err10,err20,err30,err50,err70,err80,err100};
text(X,Y,str)
title('Error cuadrático medio (MSE)'),grid on;
xlabel('Q'),ylabel('MSE');