<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="This is description">
    <title>Task 1- Web dev basics and applications</title>
    <style>
        #firstpara{
            color: blue;
            background-color: lightskyblue;
        }
        #routine{
            border-width: 2px;
            border-color: black;
            border-style: solid;
        }    
        #cells{
            border-width: 1px;
            border-color: black;
            border-style: solid;
        }
    </style>
    <style>
        td {background-color: lightgreen;
        border-style: dashed;
        border-color: black;
        border-width: 1px; }
        th {border-style: solid;
        border-width: 1px;}
    </style>
</head>
<body>
    <section>
    <h1>Introduction</h1>
    <p id="firstpara">This website is a part of assignments covered in the project web dev basics and applications under GDSC. <br> Website is created by Yuvraj Singh, a second year undergraduate from chemistry department at IIT Kanpur. <br>Purpose of wesbite is to develop basic concepts of html and css. This website will have 3 other sections with different content and purpose of learning.</p>
    </section>
    <section>
        <h3>Initial form</h3>
        <form action="backend.php">
        <div>
            Name: <input type="text" name="myName">
        </div>
        <div>
            Roll number: <input type="number" name="myRoll number">
        </div>
        <div>
            Email: <input type="email" name="myEmail" id="">
        </div>
        <div>
            Branch: <input type="text" name="myBranch">
        </div>
        <div>
            Mobile number: <input type="number" name="myMobile number">
        </div>
        <div>
            <input type="submit" value="Submit now ">
        </div>
    </form>
    </section>
    <section>
        <h3>Image section</h3>
        <p>This section has 3 rows with 5 images in each</p>
        <table>
            <tr>
                <td> <img src="https://images.pexels.com/photos/1805053/pexels-photo-1805053.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="An old red mustang car" width="300" height="200"> <br>
                <p> An old red mustang car <br> <a href="https://images.pexels.com/photos/1805053/pexels-photo-1805053.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a> 
                </p>
            </td>
                <td> <img src="https://images.pexels.com/photos/17613609/pexels-photo-17613609/free-photo-of-street-musician-playing-violin.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Man playing violen" width="300" height="200"> <br>
                <p> Man playing violen <br> <a href="https://images.pexels.com/photos/17613609/pexels-photo-17613609/free-photo-of-street-musician-playing-violin.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a>
                </p>
            </td>
                <td> <img src="https://images.pexels.com/photos/16995256/pexels-photo-16995256/free-photo-of-border-collie-on-beach.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="dog on a beach" width="300" height="200"> <br> <p> dog on a beach <br> <a href="https://images.pexels.com/photos/16995256/pexels-photo-16995256/free-photo-of-border-collie-on-beach.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/1001682/pexels-photo-1001682.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Ocean" width="300" height="200"> <br> <p> Ocean <br> <a href="https://images.pexels.com/photos/1001682/pexels-photo-1001682.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/396714/pexels-photo-396714.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Green trees" width="300" height="200"> <br> <p> Green trees <br> <a href="https://images.pexels.com/photos/1001682/pexels-photo-1001682.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a>
                </p>
            </td>
            </tr>
            <tr>
                <td> <img src="https://images.pexels.com/photos/16756656/pexels-photo-16756656/free-photo-of-black-and-white-photo-of-a-swan-on-a-lake.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Duck in black&white background" width="300" height="200"> <br> <p>Duck in black&white background <br> <a href="https://images.pexels.com/photos/16756656/pexels-photo-16756656/free-photo-of-black-and-white-photo-of-a-swan-on-a-lake.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a> 
                </p>
                </td>
                <td> <img src="https://images.pexels.com/photos/337909/pexels-photo-337909.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="A red ferrari Italia" width="300" height="200"> <br> <p>A red ferrari italia <br> <a href="https://images.pexels.com/photos/337909/pexels-photo-337909.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a>
                </p>
            </td>
                <td> <img src="https://images.pexels.com/photos/575386/pexels-photo-575386.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="A yellow camaro" width="300" height="200"> <br> <p> A yellow camaro <br><a href="https://images.pexels.com/photos/575386/pexels-photo-575386.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/1525612/pexels-photo-1525612.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Busy new york street" width="300" height="200" > <br> <p>Busy new york street <br> <a href="https://images.pexels.com/photos/1525612/pexels-photo-1525612.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"> Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/1731660/pexels-photo-1731660.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Sunny day in desert" width="300" height="200"> <br> <p>Sunny day in desert <br><a href="https://images.pexels.com/photos/1731660/pexels-photo-1731660.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
                </td>
            </tr>
            <tr>
                <td><img src="https://images.pexels.com/photos/2882234/pexels-photo-2882234.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="White jeep rubicon" width="300" height="200"> <br> <p>White jeep rubicon <br><a href="https://images.pexels.com/photos/2882234/pexels-photo-2882234.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/67557/dirt-bike-motorcycle-exhaust-67557.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Rider in a motocross rally" width="300" height="200">  <br><p>Rider in a motocross rally <br> <a href="https://images.pexels.com/photos/67557/dirt-bike-motorcycle-exhaust-67557.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/34098/south-africa-hluhluwe-giraffes-pattern.jpg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Three giraffes in african continent" width="300" height="200"> <br><p>Three giraffes in african continent <br> <a href="https://images.pexels.com/photos/34098/south-africa-hluhluwe-giraffes-pattern.jpg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/45911/peacock-plumage-bird-peafowl-45911.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Peacock" width="300" height="200"> <br> <p>Peacock <br> <a href="https://images.pexels.com/photos/45911/peacock-plumage-bird-peafowl-45911.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
            </td>
                <td><img src="https://images.pexels.com/photos/162031/dubai-tower-arab-khalifa-162031.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="The famous Burj Khalifa" width="300" height="200"> <br> <p>The famous Burj Khalifa <br><a href="https://images.pexels.com/photos/162031/dubai-tower-arab-khalifa-162031.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">Image link</a>
                </p>
            </td>
            </tr>

    </table>
    </section>
    <section>
        <h3>Timetable</h3>
        <table id="routine">
            <thead>
                <tr>
                    <th>Time slot</th>
                    <th>Monday</th>
                    <th>Tuesday</th>
                    <th>Wednesday</th>
                    <th>Thursday</th>
                    <th>Friday</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>8 am</td>
                    <td>ENG113</td>
                    <td>ENG113</td>
                    <td>ENG113</td>
                    <td>ENG113</td>
                    <td></td>
                </tr>
                <tr>
                    <td>9 am</td>
                    <td>CHM202</td>
                    <td></td>
                    <td>CHM202</td>
                    <td></td>
                    <td>CHM202</td>
                </tr>
                <tr>
                    <td>10 am</td>
                    <td>CHM222</td>
                    <td></td>
                    <td>CHM222</td>
                    <td></td>
                    <td>CHM222</td>
                </tr>
                <tr>
                    <td>11 am</td>
                    <td>CHM242</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>12 pm</td>
                    <td></td>
                    <td>CHM242</td>
                    <td></td>
                    <td></td>
                    <td>CHM242</td>
                </tr>
                <tr>
                    <td>Lunch Break</td>
                </tr>
                <tr>
                    <td>2 pm(lab)</td>
                    <td>ESC201</td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>5 pm</td>
                    <td>ESC201</td>
                    <td>ESC201</td>
                    <td>ESC201</td>
                    <td>ESC201</td>
                    <td></td>
                </tr>
            </tbody>
        </table>
    </section>
</body>
</html>