def stringreversal(string) # method reverse_string with parameter 'string'
  loop = string.length       # Get the length of the string to loop through
  rstring = ''                  # variable for reversed string
  while loop > 0
    loop -= 1
    rstring += string[loop]       # adds the current char, at index 'loop', to reversed string
  end
  return rstring
end     