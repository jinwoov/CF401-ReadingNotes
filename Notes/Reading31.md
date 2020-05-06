# HTTPS

- Https is secured http version and it makes sure that information exchange during the session is not leaked to the malware or middleman.
- During the "handshake" between browser and computer, they have two way of accessing the information. One being the symmetric key that only allows one key to encrypt and decrypt the information
- the other side of the coin is asymmetric key where there are public key and private key and public key is shared to the public to establish connection and after connection is created, they are using private key to exchange information.
- For us, the green lock or black lock by url is a sign that browser is securely exchanging information. 
- The SSL is a secure socket layer where Netscape created during the 90s and is kept until 99 when they gave away the right to IETF where they created another version of SSL call TLS. 
- TLS is called transport layer security and is currently being upkeep whereas SSL is deprecated in 2015. 
- Certificate authority is third party organization with three main objectives. 
    1. issuing the certificate
    2. confirming identification
    3. providing proof that certificate is valid

- Self-sign is also available for user's discretion, however not recommended as it is not authorized by trusted authority and will warn user from accessing this website. 
- Hence, self-sign certificate is good when you are testing your application
- salting is a way a random mix to the information so it is not decryptable by random stranger
- GDPR is a rights to people to manager personal data collected by an organization.