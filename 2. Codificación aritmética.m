clc;
clear all;
disp('ALGORITMO ARITM�TICO');
%PROCESO DE CODIFICACI�N
disp('1. Codificaci�n');
prompt='Ingrese la cadena para codificar: \n';  %se pide ingresar una cadena al usuario
str=input(prompt,'s'); %se lee la cadena que ingresa el usuario
arith=str; %se almacena la cadena original
len=size(str); 
le=len(2);
count=[];
%M�todo para encontrar el total de los s�mbolos a ser codifados
for i=1:le-1 
    count(i)=1;
    for j=i+1:le
        if str(i)==str(j)
            str(j)=0;
            count(i)=count(i)+1;
        end
    end
end
if(str(le)~=0)
    count(le)=1;
end
j=1;
%M�todo para encontrar la probabilidad de cada uno de los s�mbolos 
for i=1:le
    if(str(i)~=0)
        new(j)=str(i);
        p(j)=count(i)/le;
        if(j>1)
            ar(j)=ar(j-1)+p(j);
        else
            ar(j)=p(j);
        end
        disp(['La probabilidad de "',str(i),'" es ',num2str(p(j))]);  
        j=j+1;
    end
end
larith=size(new);
l=[];u=[];
l(1)=0;
u(1)=ar(1);
%M�todo para la codificaci�n arimm�tica
for i=2:le
    for j=1:larith(2)
        if(arith(i)==new(j))
       l(i)=l(i-1)+(u(i-1)-l(i-1))*(ar(j)-p(j)); %C�lculo del nuevo l�mite inferior
       u(i)=l(i-1)+(u(i-1)-l(i-1))*ar(j); %C�lculo del nuevo limite superior
        end
    end
end
tag=(l(i)+u(i))/2;
disp('Valor de la etiqueta = ');
disp(tag);
cadenaBin = num2str(binariofr(tag));
binario = cadenaBin(3:end);
fprintf('\n');
disp('Cadena codificada = ');
disp(binario);
fprintf('\n');
fprintf('\n');
%PROCESO DE DECODIFICACI�N
disp('ALGORITMO ARITM�TICO');
disp('2. Decodificaci�n'); 
prompt='Ingrese la etiqueta para decodificar: \n'; %Se pide que ingrese la etiqueta para decodificar
ingreso = input(prompt,'s');
tagr=str2double(ingreso);
rec='a';
for i=1:le
    for j=1:larith(2)
        if(tagr<ar(j) && tagr>(ar(j)-p(j)))
            rec(i)=new(j);
            nm=j;
        end
    end
    if(nm>1)
    tagr=(tagr-ar(nm-1))/p(nm);
    else
    tagr=tagr/p(nm);
    end
end
disp(['La cadena recuperada es:"',rec,'"']);
fprintf('\n');
if(rec==arith)
    disp('Decodificaci�n exitosa: las cadena original y la cadena recuperada son las mismas');
else 
    disp('Decodificaci�n fallida: las cadenas no son las mismas');
end
