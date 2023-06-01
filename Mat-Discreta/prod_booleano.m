function res = prod_booleano(a,b)
  c=zeros(5)

  for i=1:5
    for j=1:5
      for k = 1:5
        if a(i,k) && b(k,j)
          res(i,j)=1;
        endif
      endfor
    endfor
  endfor
endfunction
