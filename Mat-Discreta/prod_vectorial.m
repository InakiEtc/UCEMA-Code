function prod_vectorial(a,b)
  aux=0;
  res=0;
    for j=1:5
      aux = a(j) * b(j);
      res = res + aux;
    endfor
  fprintf("el res del prod vectorial es = %d \n",res);
endfunction
