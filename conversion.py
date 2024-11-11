import sys
import subprocess

f = sys.argv[1]
t = sys.argv[2]
a = float(sys.argv[3])

def conv(f, t, a):
    js = f"currency.js {f} {t} {a}"
    res = subprocess.run(["node", js], capture_output=True, text=True)
    return float(res.stdout.strip())

c = conv(f, t, a)
subprocess.run(["dotnet", "run", f, t, str(a), str(c)])

print(c)
