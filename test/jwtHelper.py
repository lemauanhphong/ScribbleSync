import sys
 
sys.path.append('..')

from middleware import jwtHelper
import time

data = {'username': 'hehe', 'exp': time.time() + 1}
t = jwtHelper.sign(data, '../key/jwtRS512.key')
print(t)
print(jwtHelper.verify(t, '../key/jwtRS512.key.pub'))