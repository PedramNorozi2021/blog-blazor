function openPostModal() {
    document.querySelector('.add-post-modal').style.top = '100px';
    document.querySelector('.post-container').style.opacity = '0.2'
    document.querySelector('#title').style.opacity = '0.2'
}
function closePostModal() {
    document.querySelector('.add-post-modal').style.top = '-1000px';
    document.querySelector('#title').style.opacity = '1'
    document.querySelector('.post-container').style.opacity = '1'
}