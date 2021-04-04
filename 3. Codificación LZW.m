%%Jaramillo-Zamora-Zumarraga
%%Implementacion del algoritmo LZW
%%Algoritmmo LZW


clc;
close all;
clear all;

cadena = input('Ingrese la cadena a codificar: \n','s');
tamanoAntes=length(cadena);
%cadena = strrep(cadena,' ','');                     %%Quita espacios en la cadena
%cadena = upper(cadena);                            %%Convierte en mayuscula la cadena
fprintf('\n');
disp('DICCIONARIO INICIAL:');
fprintf('\n');

tamano=length(cadena);

x=0;                                               %Sirve para contar cuantas letras diferentes estan en la cadena
output = {};                                       %En este vector se asignara las salidas de manera dinamica
celda = {};                                        %Celda que almacenara el diccionario principal
codigo = {};

%METODO PARA CREAR EL ALFABETO INICIAL DE MANERA DINAMICA

for j=32:122                                        %%Recorre para buscar todo el Alfabeto 32 = ' ' 33=! 65=A 90=Z 122=z en ASCII
  for i=1:tamano                                    %%Recorre toda la cadena de entrada
      if(cadena(i)==j)
          x=x+1;                                    %La variable x designara el codigo
                                                            
          celda{1,x} = cadena(i);                   %%Asignacion mejor en celdas para evitar problemas
          dicInicial{1,x} = cadena(i);
          codigo{1,x} = x;
          fprintf('Soy ´%s´ y mi codigo es %d \n',cadena(i),x);
          
          break;
      end
  end
end 

%dicInicial = celda;                                    %Guardamos el diccionario inicial.
fprintf('\n');

%%Algoritmo LZW
aux = '';                                               %Representara s+c                                           
s = {};
c = {};
aux = {};                                               
validar =0;                                             %Si validar el 0 s+c no esta en diccionario si vlidar es 1 s+c estuvo en diccionario
salida=0;
s = cadena(1);
for k=1:tamano-1 
    validar =0; 
    c = cadena(k+1);
    
    aux = strcat(s, c);                                        %Cocadena caracteres
    for l=1: x                                                 %X representa el tamaño del diccionario
        if ( strcmp(aux,celda{1,l}))                           %Pregunto si el valor de aux=s+c esta en el diccionario
            validar =1; 
            break
        end
    end
    
    if (validar==1)         
        s='';
        s = aux;
    elseif (validar==0)
        x=x+1;
         for m=1: x                                           %X representa el tamaño del diccionario
           if ( strcmp(s,celda{1,m}))                         %Pregunto si el valor de aux=s+c esta en el diccionario
               salida=salida+1;                               %define el tamaño de la salida output
               output{1,salida}=m;          
            break
           end
        end
        
        celda{1,x}=aux;
        s=c;
          
    end
end


%%-----ULTIMO CARACTER------%%
for m=1: x                                                   %X representa el tamaño del diccionario
       if ( strcmp(s,celda{1,m}))                            %Pregunto si el valor de aux=s+c esta en el diccionario
             salida=salida+1;                                %define el tamaño de la salida output
             output{1,salida}=m;          
            break
       end
end


fprintf('El   String    final es');
disp(celda);
fprintf('La salida codificada es');
disp(output);
tamanoDespues=length(output);
fprintf('\n');
fprintf('La tasa de compresion es:');
disp(tamanoAntes/tamanoDespues);
fprintf('\n');
fprintf('----------------------DECODIFICADOR---------------------\n');
fprintf('\n');
cadena = input('Ingrese la cadena a decodificar: \n','s');
fprintf('\n');
disp('DICCIONARIO INICIAL A UTILIZAR ES:');
disp(dicInicial);
fprintf('\n');

%%%%-----------------DECODIFICADOR----------------%%%%
tamanoDicionario = length(dicInicial);
entrada = {}; 
code    = {};
%string =  {};
s = '';
for i=1:length(cadena)
    k = cadena(i);           %Recorre todo la cadena
    k=k-48;                  %Le resto 48 debido a q el valor sale en ASCII
    entrada{1,i}= dicInicial{1,k} ;
    
    validar=0;
    for z=1:length(dicInicial)
        if(strcmp(strcat(s, entrada{1,i}(1)),dicInicial(z)))
            validar=1;                 %%1 es q esta en dicionario
            break;
        end
    end
    
    if(validar==0)
        tamanoDicionario = tamanoDicionario+1;
        dicInicial{1,tamanoDicionario} = strcat(s, entrada{1,i}(1));
    end
    s = entrada{1,i};
end

fprintf('La cadena decodificada es: \n');
disp(entrada);
fprintf('\n');