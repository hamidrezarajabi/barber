function toggleDropdown(id) {
    var dropdowns = document.getElementsByClassName("dropdown-content");
    for (var i = 0; i < dropdowns.length; i++) {
        if (dropdowns[i].id !== id) {
            dropdowns[i].classList.remove("show");
        }
    }
    document.getElementById(id).classList.toggle("show");
}

function filterLocation(location) {
    console.log("Selected location: " + location);
    // Add filtering logic here
}

function filterType(type) {
    console.log("Selected type: " + type);
    // Add filtering logic here
}

function filterRate(rate) {
    console.log("Selected rate: " + rate);
    // Add filtering logic here
}

function filterLocation(location) {
    const items = document.querySelectorAll('.item'); // انتخاب همه آیتم‌ها
    items.forEach(item => {
        if (location === '' || item.getAttribute('data-location') === location) {
            item.style.display = 'block'; // نمایش آیتم‌های مرتبط یا همه آیتم‌ها
        } else {
            item.style.display = 'none'; // مخفی کردن آیتم‌های نامرتبط
        }
    });
}



function filterCategory(category) {
    var items = document.querySelectorAll('.item');
    items.forEach(function(item) {
        if (item.getAttribute('data-category') === category) {
            item.style.display = "block";
        } else {
            item.style.display = "none";
        }
    });
}
function loadRatings() {
    fetch('rating.html')
        .then(response => response.text())
        .then(data => {
            const containers = document.querySelectorAll('.rating-container');
            containers.forEach(container => container.innerHTML = data);
        });
}

// فراخوانی تابع بعد از لود کامل صفحه
document.addEventListener('DOMContentLoaded', loadRatings);

document.getElementById('commentForm').addEventListener('submit', function(e) {
    e.preventDefault();
    
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const comment = document.getElementById('comment').value;
    const rating = document.getElementById('rating').value;
    
    // اینجا می‌توانید نظر را به یک سرور ارسال کنید یا به لیست نظرات اضافه کنید
    alert(`نظر شما با موفقیت ثبت شد!\nنام: ${name}\nایمیل: ${email}\nنظر: ${comment}\nامتیاز: ${rating}`);
    
    // فرم را ریست کنید
    document.getElementById('commentForm').reset();
});


document.getElementById('contactForm').addEventListener('submit', function(e) {
    e.preventDefault();
    
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const message = document.getElementById('message').value;
    
    // اینجا می‌توانید اطلاعات فرم را به یک سرور ارسال کنید
    alert(`پیام شما با موفقیت ارسال شد!\nنام: ${name}\nایمیل: ${email}\nشماره تلفن: ${phone}\nپیام: ${message}`);
    
    // فرم را ریست کنید
    document.getElementById('contactForm').reset();
});

fetch('/api/restaurants')
    .then(response => response.json())
    .then(data => {
        console.log('Restaurants:', data);
        // نمایش داده‌ها در صفحه HTML
    })
    .catch(error => console.error('Error fetching restaurants:', error));


    
