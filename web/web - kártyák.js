function kartyakMegjelenitese(jsonData){
    const osszesKartya = document.querySelector('#osszesKartya');
    osszesKartya.innerHTML = '';

    jsonData.reverse();
    for (let i = 0; i < jsonData.length; i++) {
        const element = jsonData[i];
        
        const egyKartya = document.createElement('div');
        egyKartya.className = 'card m-2';

        let egyKartyaTartalma = `
            <div class="card-body">
                <p class="h5 card-title">${element.valami}</p>
                <p class="card-text">${element.valamiMas}</p>
                <a href="#" class="btn btn-primary" onclick="selectElement(${element.id});">Kiválaszt</a>
            </div>
        `;
        egyKartya.innerHTML = egyKartyaTartalma;
        osszesKartya.appendChild(egyKartya);
    }
}