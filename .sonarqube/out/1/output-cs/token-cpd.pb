�
aC:\Cursos\Codificación Segura\ProyectoFinalSeguridadApps\Business_SeguridadApps\BusinessRules.cs
	namespace 	"
Business_SeguridadApps
  
{		 
public

 

class

 


 
{ 
static
readonly
string
notvalid_chr
=
$str
;
static 
readonly 
string 
creditcard_pattern 1
=2 3
$str4 ^
;^ _
const 
string 
pattern 
= 
$str 4
;4 5
bool 

( 
string !
InputString" -
)- .
{ 	
try 
{ 
return 
Regex 
. 
IsMatch $
($ %
InputString% 0
,0 1
pattern2 9
)9 :
;: ;
} 
catch 
( &
RegexMatchTimeoutException -
)- .
{ 
return 
false 
; 
} 
}!! 	
public'' 
InputResult'' 
ValidateInputText'' ,
('', -
string''- 3
InputString''4 ?
)''? @
{(( 	
InputResult)) 
result)) 
=))  
new))! $
InputResult))% 0
())0 1
)))1 2
;))2 3
try** 
{++ 
result,, 
.,, 
IsMatch,, 
=,,  

(,,. /
InputString,,/ :
),,: ;
;,,; <
if-- 
(-- 
!-- 
result-- 
.-- 
IsMatch-- #
)--# $
{.. 
result// 
.// 
SanitizedString// *
=//+ ,
Regex//- 2
.//2 3
Replace//3 :
(//: ;
InputString//; F
,//F G

,//U V
$str//W Y
)//Y Z
;//Z [
if00 
(00 
result00 
.00 
SanitizedString00 .
.00. /
Length00/ 5
<006 7
InputString008 C
.00C D
Length00D J
)00J K
{11 
result22 
.22 
Message22 &
=22' (
$str22) X
+22Y Z
result22[ a
.22a b
SanitizedString22b q
;22q r
}33 
result44 
.44 
IsMatch44 "
=44# $
true44% )
;44) *
}55 
else66 
{77 
result99 
.99 
SanitizedString99 *
=99+ ,
InputString99- 8
;998 9
result:: 
.:: 
Message:: "
=::# $
$str::% A
;::A B
};; 
}<< 
catch== 
(== &
RegexMatchTimeoutException== -
ex==. 0
)==0 1
{>> 
result?? 
.?? 
IsMatch?? 
=??  
false??! &
;??& '
result@@ 
.@@ 
Message@@ 
=@@  
ex@@! #
.@@# $
Message@@$ +
;@@+ ,
}AA 
returnBB 
resultBB 
;BB 
}CC 	
publicII 

CreditCardII 
GetCreditCardInfoII +
(II+ ,
stringII, 2
	inputTextII3 <
)II< =
{JJ 	

CreditCardKK 
ccKK 
=KK 
newKK 

CreditCardKK  *
(KK* +
)KK+ ,
;KK, -
tryLL 
{MM 
ccNN 
.NN 
CreditCardNumberNN #
=NN$ %
GetCreditCardNumNN& 6
(NN6 7
	inputTextNN7 @
)NN@ A
;NNA B
ccOO 
.OO 
IndexOO 
=OO "
GetCreditCardNum_IndexOO 1
(OO1 2
	inputTextOO2 ;
)OO; <
;OO< =
ifPP 
(PP 
!PP 
stringPP 
.PP 

(PP) *
ccPP* ,
.PP, -
CreditCardNumberPP- =
)PP= >
)PP> ?
{QQ 
ccRR 
.RR 
IsValidRR 
=RR  
trueRR! %
;RR% &
intSS 
indexSS 
=SS "
GetCreditCardNum_IndexSS  6
(SS6 7
ccSS7 9
.SS9 :
CreditCardNumberSS: J
)SSJ K
;SSK L
varTT 
cardNumber_leftTT '
=TT( )
newTT* -

(TT; <
ccTT< >
.TT> ?
CreditCardNumberTT? O
.TTO P
	SubstringTTP Y
(TTY Z
$numTTZ [
,TT[ \
indexTT] b
)TTb c
)TTc d
;TTd e
varUU 
cardNumber_rightUU (
=UU) *
newUU+ .

(UU< =
ccUU= ?
.UU? @
CreditCardNumberUU@ P
.UUP Q
	SubstringUUQ Z
(UUZ [
indexUU[ `
+UUa b
$numUUc e
)UUe f
)UUf g
;UUg h
stringVV 

=VV) *
ccVV+ -
.VV- .
CreditCardNumberVV. >
.VV> ?
	SubstringVV? H
(VVH I
$numVVI J
,VVJ K
ccVVL N
.VVN O
CreditCardNumberVVO _
.VV_ `
LengthVV` f
-VVg h
$numVVi j
)VVj k
;VVk l
stringWW 
visible_stringWW )
=WW* +
ccWW, .
.WW. /
CreditCardNumberWW/ ?
.WW? @
	SubstringWW@ I
(WWI J
ccWWJ L
.WWL M
CreditCardNumberWWM ]
.WW] ^
LengthWW^ d
-WWe f
$numWWg h
)WWh i
;WWi j
varYY 

=YY& '
newYY( +

(YY9 :
)YY: ;
;YY; <
forZZ 
(ZZ 
intZZ 
iZZ 
=ZZ  
$numZZ! "
;ZZ" #
iZZ$ %
<ZZ& '

.ZZ5 6
LengthZZ6 <
;ZZ< =
iZZ> ?
++ZZ? A
)ZZA B
{[[ 
if\\ 
(\\ 

.\\) *
	Substring\\* 3
(\\3 4
i\\4 5
,\\5 6
$num\\7 8
)\\8 9
.\\9 :
	CompareTo\\: C
(\\C D
$str\\D G
)\\G H
==\\I K
$num\\L M
||\\N P
string\\Q W
.\\W X
IsNullOrWhiteSpace\\X j
(\\j k

.\\x y
	Substring	\\y �
(
\\� �
i
\\� �
,
\\� �
$num
\\� �
)
\\� �
)
\\� �
)
\\� �

.]]) *
Append]]* 0
(]]0 1

.]]> ?
	Substring]]? H
(]]H I
i]]I J
,]]J K
$num]]L M
)]]M N
)]]N O
;]]O P
else^^ 

.__) *
Append__* 0
(__0 1

.__> ?
	Substring__? H
(__H I
i__I J
,__J K
$num__L M
)__M N
.__N O
Replace__O V
(__V W

.__d e
	Substring__e n
(__n o
i__o p
,__p q
$num__r s
)__s t
,__t u
$str__v y
)__y z
)__z {
;__{ |
}aa 
varbb 
cardNumber_maskedbb )
=bb* +

.bb9 :
Appendbb: @
(bb@ A
visible_stringbbA O
)bbO P
;bbP Q
cccc 
.cc 
CreditCardMaskedcc '
=cc' (
(cc) *
cardNumber_leftcc* 9
.cc9 :
Appendcc: @
(cc@ A
cardNumber_maskedccA R
)ccR S
.ccS T
AppendccT Z
(ccZ [
cardNumber_rightcc[ k
)cck l
)ccl m
.ccm n
ToStringccn v
(ccv w
)ccw x
;ccx y
}dd 
elseee 
{ff 
ccgg 
.gg 
Messagegg 
=gg  !
$strgg" u
;ggu v
throwhh 
newhh !
ArgumentNullExceptionhh 3
(hh3 4
cchh4 6
.hh6 7
Messagehh7 >
)hh> ?
;hh? @
}ii 
}jj 
catchkk 
(kk 
	Exceptionkk 
)kk 
{ll 
ccmm 
.mm 
IsValidmm 
=mm 
falsemm "
;mm" #
}nn 
returnoo 
ccoo 
;oo 
}qq 	
stringww 
GetCreditCardNumww 
(ww  
stringww  &
	inputTextww' 0
)ww0 1
{xx 	
Matchyy 
cardIdyy 
=yy 
Regexyy  
.yy  !
Matchyy! &
(yy& '
	inputTextyy' 0
,yy0 1
creditcard_patternyy2 D
)yyD E
;yyE F
ifzz 
(zz 
cardIdzz 
.zz 
Successzz 
)zz 
return{{ 
cardId{{ 
.{{ 
Value{{ #
;{{# $
else|| 
return}} 
string}} 
.}} 
Empty}} #
;}}# $
}~~ 	
int
�� $
GetCreditCardNum_Index
�� "
(
��" #
string
��# )
	inputText
��* 3
)
��3 4
{
�� 	
Match
�� 
cardId
�� 
=
�� 
Regex
��  
.
��  !
Match
��! &
(
��& '
	inputText
��' 0
,
��0 1 
creditcard_pattern
��2 D
)
��D E
;
��E F
if
�� 
(
�� 
cardId
�� 
.
�� 
Success
�� 
)
�� 
return
�� 
cardId
�� 
.
�� 
Index
�� #
;
��# $
else
�� 
return
�� 
$num
�� 
;
�� 
}
�� 	
public
�� 
EncodingData
��  
EncodingCreditCard
�� .
(
��. /
string
��/ 5
data
��6 :
)
��: ;
{
�� 	
EncodingData
�� 
ed
�� 
=
�� 
new
�� !
EncodingData
��" .
(
��. /
)
��/ 0
;
��0 1
try
�� 
{
�� 
ed
�� 
.
�� 

cryptoData
�� 
=
�� #
AES256_EncryptManaged
��  5
(
��5 6
data
��6 :
)
��: ;
;
��; <
ed
�� 
.
�� 
SHA256
�� 
=
�� 
GenerateSHA256
�� *
(
��* +
data
��+ /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
ed
�� 
.
�� 
Message
�� 
=
�� 
ex
�� 
.
��  
Message
��  '
;
��' (
}
�� 
return
�� 
ed
�� 
;
�� 
}
�� 	
string
�� 
GenerateSHA256
�� 
(
�� 
string
�� $
MaskedInput
��% 0
)
��0 1
{
�� 	

�� 
hash
�� 
=
��  
new
��! $

��% 2
(
��2 3
)
��3 4
;
��4 5
using
�� 
(
�� 
SHA256
�� 
sha256
��  
=
��! "
SHA256
��# )
.
��) *
Create
��* 0
(
��0 1
)
��1 2
)
��2 3
{
�� 
byte
�� 
[
�� 
]
�� 
	hashValue
��  
=
��! "
sha256
��# )
.
��) *
ComputeHash
��* 5
(
��5 6
Encoding
��6 >
.
��> ?
UTF8
��? C
.
��C D
GetBytes
��D L
(
��L M
MaskedInput
��M X
)
��X Y
)
��Y Z
;
��Z [
foreach
�� 
(
�� 
byte
�� 
b
�� 
in
��  "
	hashValue
��# ,
)
��, -
{
�� 
hash
�� 
.
�� 
Append
�� 
(
��  
b
��  !
.
��! "
ToString
��" *
(
��* +
$str
��+ /
)
��/ 0
)
��0 1
;
��1 2
}
�� 
}
�� 
return
�� 
hash
�� 
.
�� 
ToString
��  
(
��  !
)
��! "
;
��" #
}
�� 	

CryptoData
�� #
AES256_EncryptManaged
�� (
(
��( )
string
��) /

��0 =
)
��= >
{
�� 	

CryptoData
�� 
cd
�� 
=
�� 
new
�� 

CryptoData
��  *
(
��* +
)
��+ ,
;
��, -
try
�� 
{
�� 
using
�� 
(
�� 

AesManaged
�� !
aes_managed
��" -
=
��. /
new
��0 3

AesManaged
��4 >
(
��> ?
)
��? @
)
��@ A
{
�� 
cd
�� 
.
�� 
	Encrypted
��  
=
��! "
Encrypt
��# *
(
��* +

��+ 8
,
��8 9
aes_managed
��: E
.
��E F
Key
��F I
,
��I J
aes_managed
��K V
.
��V W
IV
��W Y
)
��Y Z
;
��Z [
cd
�� 
.
�� 
	Decrypted
��  
=
��! "
Decrypt
��# *
(
��* +
cd
��+ -
.
��- .
	Encrypted
��. 7
,
��7 8
aes_managed
��9 D
.
��D E
Key
��E H
,
��H I
aes_managed
��J U
.
��U V
IV
��V X
)
��X Y
;
��Y Z
if
�� 
(
�� 

�� %
.
��% &
	CompareTo
��& /
(
��/ 0
cd
��0 2
.
��2 3
	Decrypted
��3 <
)
��< =
==
��> @
$num
��A B
)
��B C
{
�� 
cd
�� 
.
�� 
Message
�� "
=
��# $
$str
��% <
;
��< =
cd
�� 
.
�� 
Done
�� 
=
��  !
true
��" &
;
��& '
}
�� 
else
�� 
{
�� 
cd
�� 
.
�� 
Done
�� 
=
��  !
false
��" '
;
��' (
cd
�� 
.
�� 
Message
�� "
=
��# $
$str
��% }
;
��} ~
}
�� 
}
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
cd
�� 
.
�� 
Message
�� 
=
�� 
ex
�� 
.
��  
Message
��  '
;
��' (
cd
�� 
.
�� 
Done
�� 
=
�� 
false
�� 
;
��  
}
�� 
return
�� 
cd
�� 
;
�� 
}
�� 	
byte
�� 
[
�� 
]
��
Encrypt
�� 
(
�� 
string
�� 

�� +
,
��+ ,
byte
��- 1
[
��1 2
]
��2 3
Key
��4 7
,
��7 8
byte
��9 =
[
��= >
]
��> ?
IV
��@ B
)
��B C
{
�� 	
byte
�� 
[
�� 
]
�� 
	encrypted
�� 
;
�� 
using
�� 
(
�� 

AesManaged
�� 
aes_managed
�� )
=
��* +
new
��, /

AesManaged
��0 :
(
��: ;
)
��; <
)
��< =
{
�� 
ICryptoTransform
��  
	encryptor
��! *
=
��+ ,
aes_managed
��- 8
.
��8 9
CreateEncryptor
��9 H
(
��H I
Key
��I L
,
��L M
IV
��N P
)
��P Q
;
��Q R
using
�� 
(
�� 
MemoryStream
�� #
ms
��$ &
=
��' (
new
��) ,
MemoryStream
��- 9
(
��9 :
)
��: ;
)
��; <
{
�� 
using
�� 
(
�� 
CryptoStream
�� '
cs
��( *
=
��+ ,
new
��- 0
CryptoStream
��1 =
(
��= >
ms
��> @
,
��@ A
	encryptor
��B K
,
��K L
CryptoStreamMode
��M ]
.
��] ^
Write
��^ c
)
��c d
)
��d e
{
�� 
using
�� 
(
�� 
StreamWriter
�� +
sw
��, .
=
��/ 0
new
��1 4
StreamWriter
��5 A
(
��A B
cs
��B D
)
��D E
)
��E F
sw
�� 
.
�� 
Write
�� $
(
��$ %

��% 2
)
��2 3
;
��3 4
	encrypted
�� !
=
��" #
ms
��$ &
.
��& '
ToArray
��' .
(
��. /
)
��/ 0
;
��0 1
}
�� 
}
�� 
}
�� 
return
�� 
	encrypted
�� 
;
�� 
}
�� 	
string
�� 
Decrypt
�� 
(
�� 
byte
�� 
[
�� 
]
�� 

�� +
,
��+ ,
byte
��- 1
[
��1 2
]
��2 3
Key
��4 7
,
��7 8
byte
��9 =
[
��= >
]
��> ?
IV
��@ B
)
��B C
{
�� 	
string
�� 
decryptText
�� 
=
��  
string
��! '
.
��' (
Empty
��( -
;
��- .
using
�� 
(
�� 

AesManaged
�� 
aes_managed
�� )
=
��* +
new
��, /

AesManaged
��0 :
(
��: ;
)
��; <
)
��< =
{
�� 
ICryptoTransform
��  
	decryptor
��! *
=
��+ ,
aes_managed
��- 8
.
��8 9
CreateDecryptor
��9 H
(
��H I
Key
��I L
,
��L M
IV
��N P
)
��P Q
;
��Q R
using
�� 
(
�� 
MemoryStream
�� #
ms
��$ &
=
��' (
new
��) ,
MemoryStream
��- 9
(
��9 :

��: G
)
��G H
)
��H I
{
�� 
using
�� 
(
�� 
CryptoStream
�� '
cs
��( *
=
��+ ,
new
��- 0
CryptoStream
��1 =
(
��= >
ms
��> @
,
��@ A
	decryptor
��B K
,
��K L
CryptoStreamMode
��M ]
.
��] ^
Read
��^ b
)
��b c
)
��c d
{
�� 
using
�� 
(
�� 
StreamReader
�� +
reader
��, 2
=
��3 4
new
��5 8
StreamReader
��9 E
(
��E F
cs
��F H
)
��H I
)
��I J
{
�� 
decryptText
�� '
=
��( )
reader
��* 0
.
��0 1
	ReadToEnd
��1 :
(
��: ;
)
��; <
;
��< =
}
�� 
}
�� 
}
�� 
}
�� 
return
�� 
decryptText
�� 
;
�� 
}
�� 	
}
�� 
}�� �
kC:\Cursos\Codificación Segura\ProyectoFinalSeguridadApps\Business_SeguridadApps\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str 1
)1 2
]2 3
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 /
)		/ 0
]		0 1
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str '
)' (
]( )
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 3
)3 4
]4 5
[
assembly
:

AssemblyCopyright
(
$str
)
]
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *�
^C:\Cursos\Codificación Segura\ProyectoFinalSeguridadApps\Business_SeguridadApps\Structures.cs
	namespace 	"
Business_SeguridadApps
  
.  !

{ 
public 

class 
InputResult 
{ 
public 
bool 
IsMatch 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Message 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
SanitizedString %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
public 

class 

CreditCard 
{ 
public 
bool 
IsValid 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
CreditCardNumber &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
CreditCardMasked &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
int 
Index 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Message 
{ 
get  #
;# $
set% (
;( )
}* +
} 
public## 

class## 

CryptoData## 
{## 
public$$ 
byte$$ 
[$$ 
]$$ 
	Encrypted$$ 
{$$  !
get$$" %
;$$% &
set$$' *
;$$* +
}$$, -
public%% 
string%% 
	Decrypted%% 
{%%  !
get%%" %
;%%% &
set%%' *
;%%* +
}%%, -
public&& 
string&& 
Message&& 
{&& 
get&&  #
;&&# $
set&&% (
;&&( )
}&&* +
public'' 
bool'' 
Done'' 
{'' 
get'' 
;'' 
set''  #
;''# $
}''% &
}(( 	
public,, 

class,, 
EncodingData,, 
{-- 
public.. 

CryptoData.. 

cryptoData.. $
{..% &
get..' *
;..* +
set.., /
;../ 0
}..1 2
public// 
string// 
SHA256// 
{// 
get// "
;//" #
set//$ '
;//' (
}//) *
public00 
string00 
Message00 
{00 
get00  #
;00# $
set00% (
;00( )
}00* +
}11 
}22 