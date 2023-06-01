function res = prodiva(m)
  res=0;
  num=0;
  for i = 1:5
    num = m(i,3) * m(i,4);
    res = res + num;
  endfor
  res = res * 1.21;
endfunction

