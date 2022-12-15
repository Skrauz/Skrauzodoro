$('document').ready(function () {
    
    let taskNameInput = $('#trackerTaskNameInput')
    let taskNameParagraph = $('#taskName')
    
    $('#trackerStartButton').on("click", () => {
        let taskName = taskNameInput.val()

        
    })
    
    taskNameInput.on("keyup", () => {
        if(taskNameInput.val() != "")
        {
            taskNameParagraph.html(taskNameInput.val())
        } else {
            taskNameParagraph.html("~")
        }
    })
})